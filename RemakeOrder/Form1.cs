using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RemakeOrder
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      pnlOrderInfo.Controls.Clear();
      if (txtOrderNum.Text.Equals(String.Empty))
      {
        MessageBox.Show("Please enter an order number.");
        return;
      }

      string orderNum = txtOrderNum.Text;
      string orderFolder = orderNum + ".order";
      string orderPath = findOrder(orderFolder);

      if (orderPath.Equals(string.Empty))
      {
        Label txtLabel = new Label();
        txtLabel.Name = "lblOrderInfo";
        txtLabel.Text = "Order not found.";
        txtLabel.Left = 6;
        txtLabel.Top = 5;

        pnlOrderInfo.Controls.Add(txtLabel);
      }
      else
      {
        showOrderInfo(orderPath, orderNum);
        showProductInfo(orderPath, orderNum);
      }
    } //end btnSearch_Click

    private void showOrderInfo(string orderPath, string orderNum)
    {
      string orderXmlPath = Path.Combine(orderPath, orderNum + ".xml");
      XDocument orderXml = XDocument.Load(orderXmlPath);
      var qryOrderFields = from orderFields in orderXml.Descendants("apm_order")
                           select orderFields;
      foreach (var orderField in qryOrderFields)
      {
        if (orderField.Element("store") != null)
        {
          addTxtBox("Store Number: ", orderField.Element("store").Attribute("store_id").Value, "txtStoreNum", 6, 5);
          addTxtBox("Store Phone: ", orderField.Element("store").Attribute("store_phone").Value, "txtStorePhone", 6, 27);
          addTxtBox("APM ID: ", orderField.Attribute("apm_id").Value, "txtApmId", 6, 49);
          addTxtBox("Customer Name: ",
            orderField.Element("shipment").Attribute("fname").Value + " " + orderField.Element("shipment").Attribute("lname").Value,
            "txtCustName", 6, 71);
          addTxtBox("Customer Phone: ", orderField.Element("shipment").Attribute("phone").Value, "txtCustPhone", 6, 93);
        }
        else
        {
          addTxtBox("Customer Name: ",
            orderField.Element("shipment").Attribute("fname").Value + " " + orderField.Element("shipment").Attribute("lname").Value,
            "txtCustName", 6, 5);
          addTxtBox("Phone: ", orderField.Element("shipment").Attribute("phone").Value, "txtCustPhone", 6, 27);
          addTxtBox("Email: ", orderField.Element("shipment").Attribute("email").Value, "txtCustEmail", 6, 49);
          addTxtBox("Address: ", orderField.Element("shipment").Attribute("address1").Value, "txtCustAddr", 6, 71);
          addTxtBox("City: ", orderField.Element("shipment").Attribute("city").Value, "txtCustCity", 6, 93);
          addTxtBox("State: ", orderField.Element("shipment").Attribute("state").Value, "txtCustState", 6, 115);
          addTxtBox("Zip: ", orderField.Element("shipment").Attribute("zip").Value, "txtCustZip", 6, 137);
          addTxtBox("Delivery Method: ", orderField.Element("shipment").Attribute("delivery_method").Value, "txtDeliveryMethod", 6, 159);
        }
      }
    } //end showOrderInfo

    private void showProductInfo(string orderPath, string orderNum)
    {
      string orderXmlPath = Path.Combine(orderPath, orderNum + ".xml");
      XDocument orderXml = XDocument.Load(orderXmlPath);
      var qryProducts = from products in orderXml.Elements("apm_order").Elements("shipment").Elements("order_item")
                             select products;
      int i = 0;
      double q = 8.68;
      foreach (var product in qryProducts)
      {
        double dblyStart = (i + q) * 22;
        int yStart = Convert.ToInt32(dblyStart);
        Label redoLabel = new Label();
        redoLabel.Text = "Remake this item? ";
        redoLabel.Left = 6;
        redoLabel.Top = yStart - 2;
        redoLabel.Name = "redoLabel_" + i;

        CheckBox chkBox = new CheckBox();
        chkBox.Checked = false;
        chkBox.Name = "chkRedo_" + i;
        chkBox.Left = 106;
        chkBox.Top = yStart - 8;

        pnlOrderInfo.Controls.Add(redoLabel);
        pnlOrderInfo.Controls.Add(chkBox);

        yStart += 22;
        addTxtBox("Product: ", product.Attribute("name").Value, "txtProdName_" + i, 6, yStart);
        yStart += 22;
        addTxtBox("Product Id: ", product.Attribute("product").Value, "txtProductId_" + i, 6, yStart);
        yStart += 22;
        addTxtBox("Quantity: ", product.Attribute("quantity").Value, "txtQuantity_" + i, 6, yStart);
        yStart += 32;

        q = yStart / 22;
        i += 1;
      }
    } //end showProductInfo

    private void addTxtBox(string txtBoxLabel, string txtBoxValue, string txtBoxName, int xStart, int yStart)
    {
      Label txtLabel = new Label();
      txtLabel.Text = txtBoxLabel;
      txtLabel.Left = xStart;
      txtLabel.Top = yStart;

      TextBox txtBox = new TextBox();
      txtBox.Name = txtBoxName;
      txtBox.Text = txtBoxValue;
      txtBox.Left = 106;
      txtBox.Top = yStart - 5;
      txtBox.Width = 198;

      pnlOrderInfo.Controls.Add(txtLabel);
      pnlOrderInfo.Controls.Add(txtBox);
    } //end addTxtBox

    private static string findOrder(string orderFolder)
    {
      string orderPath = string.Empty;
      string xmlSettings = @"C:\Program Files\ITS\RemakeOrder\remakeorder.xml";
      XDocument folderPaths = XDocument.Load(xmlSettings);
      var qrySearchFolders = from paths in folderPaths.Elements("folder_paths").Elements("search_folders").Elements("location")
                           select paths;
      foreach (XElement path in qrySearchFolders)
      {
        string searchFolder = Path.Combine(path.Value, orderFolder);
        if (Directory.Exists(searchFolder))
        {
          orderPath = searchFolder;
          break;
        }
      }
      return orderPath;
    } //end findOrder
  }
}
