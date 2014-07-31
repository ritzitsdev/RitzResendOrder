﻿using System;
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
      lblOrderPath.Text = orderPath;

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
            try { addTxtBox("Store Phone: ", orderField.Element("store").Attribute("store_phone").Value, "txtStorePhone", 6, 27); }
            catch { addTxtBox("Store Phone: ", "", "txtStorePhone", 6, 27);}
            addTxtBox("APM ID: ", orderField.Attribute("apm_id").Value, "txtApmId", 6, 49);
            addTxtBox("Customer Name: ",
              orderField.Element("shipment").Attribute("fname").Value + " " + orderField.Element("shipment").Attribute("lname").Value,
              "txtCustName", 6, 71);
            addTxtBox("Customer Phone: ", orderField.Element("shipment").Attribute("phone").Value, "txtCustPhone", 6, 93);
        }
        else
        {
            addTxtBox("Customer Name: ",
              orderField.Element("customer").Attribute("fname").Value + " " + orderField.Element("shipment").Attribute("lname").Value,
              "txtCustName", 6, 5);
            addTxtBox("Phone: ", orderField.Element("customer").Attribute("phone").Value, "txtCustPhone", 6, 27);
            addTxtBox("Email: ", orderField.Element("customer").Attribute("email").Value, "txtCustEmail", 6, 49);
            addTxtBox("Address1: ", orderField.Element("customer").Attribute("address1").Value, "txtCustAddr1", 6, 71);
            addTxtBox("Address2: ", orderField.Element("customer").Attribute("address2").Value, "txtCustAddr2", 6, 93);
            addTxtBox("City: ", orderField.Element("customer").Attribute("city").Value, "txtCustCity", 6, 115);
            addTxtBox("State: ", orderField.Element("customer").Attribute("state").Value, "txtCustState", 6, 137);
            addTxtBox("Zip: ", orderField.Element("customer").Attribute("zip").Value, "txtCustZip", 6, 159);
            addTxtBox("Delivery Method: ", orderField.Element("shipment").Attribute("delivery_method").Value, "txtDeliveryMethod", 6, 181);
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
      int x = pnlOrderInfo.Controls["txtCustPhone"].Top;
      double q = 9.68;
      if (x > 27) { q = 5.68; }
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

    private void btnCancel_Click(object sender, EventArgs e)
    {
      pnlOrderInfo.Controls.Clear();
      txtOrderNum.Text = string.Empty;
    }

    private void btnRemake_Click(object sender, EventArgs e)
    {
      string orderPath = lblOrderPath.Text;
      string orderNum = txtOrderNum.Text;
      string newOrderNum = "R" + orderNum;
      string newOrderFolder = string.Empty;
      XDocument xmlOutputFolder = XDocument.Load(@"C:\Program Files\ITS\RemakeOrder\remakeorder.xml");
      var qryOutputFolders = from outputFolders in xmlOutputFolder.Elements("folder_paths").Elements("print_folder")
                          select outputFolders;
      foreach (XElement outputFolder in qryOutputFolders)
      {
        newOrderFolder = outputFolder.Value;
      }

      string newOrderPath = Path.Combine(newOrderFolder, newOrderNum + ".temp");
      if (!Directory.Exists(newOrderPath))
      {
        Directory.CreateDirectory(newOrderPath);
      }
      // original directory info
      DirectoryInfo dir = new DirectoryInfo(orderPath);
      FileInfo[] files = dir.GetFiles();
      foreach (FileInfo file in files)
      {
        file.CopyTo(Path.Combine(newOrderPath, file.Name), true);
      }
      //rename order xml
      string newOrderXml = Path.Combine(newOrderPath, newOrderNum + ".xml");
      if (File.Exists(newOrderXml)) { File.Delete(newOrderXml); }
      File.Move(Path.Combine(newOrderPath, orderNum + ".xml"), newOrderXml);

      modifyOrderXml(newOrderXml, newOrderNum);
      string orderFolderReady = newOrderPath.Replace("temp", "order");
      Directory.Move(newOrderPath, orderFolderReady);
      pnlOrderInfo.Controls.Clear();
      txtOrderNum.Text = string.Empty;

      string doneMessage = "Changes saved and order submitted for reprocessing.\nThe new order number is " + newOrderNum;
      MessageBox.Show(doneMessage);
    } //end btnCancel_Click

    private void modifyOrderXml(string newOrderXml, string newOrderNum)
    {
      XDocument orderXml = XDocument.Load(newOrderXml);
      var qryOrderXml = from elements in orderXml.Descendants("apm_order")
                        select elements;
      foreach (var element in qryOrderXml)
      {
        element.Attribute("apm_order_number").Value = newOrderNum;
        element.Add(new XAttribute("reprint_timestamp", DateTime.Now));
        if (element.Element("store") != null)
        {
          element.Element("store").Attribute("store_id").Value = pnlOrderInfo.Controls["txtStoreNum"].Text;
          if (element.Element("store").Attribute("store_phone") != null)
          {
            element.Element("store").Attribute("store_phone").Value = pnlOrderInfo.Controls["txtStorePhone"].Text;
          }
          else
          {
            element.Element("store").Add(new XAttribute("store_number", pnlOrderInfo.Controls["txtStorePhone"].Text));
          }
          element.Attribute("apm_id").Value = pnlOrderInfo.Controls["txtApmId"].Text;
          string custName = pnlOrderInfo.Controls["txtCustName"].Text;
          string[] custFirstLast = custName.Split(new Char[] { ' ' });
          element.Element("shipment").Attribute("fname").Value = custFirstLast[0];
          element.Element("shipment").Attribute("lname").Value = custFirstLast[1];
          element.Element("shipment").Attribute("phone").Value = pnlOrderInfo.Controls["txtCustPhone"].Text;
        }
        else
        {
          string custName = pnlOrderInfo.Controls["txtCustName"].Text;
          string[] custFirstLast = custName.Split(new Char[]{' '});
          element.Element("customer").Attribute("fname").Value = custFirstLast[0];
          element.Element("customer").Attribute("lname").Value = custFirstLast[1];
          element.Element("customer").Attribute("phone").Value = pnlOrderInfo.Controls["txtCustPhone"].Text;
          element.Element("customer").Attribute("email").Value = pnlOrderInfo.Controls["txtCustEmail"].Text;
          element.Element("customer").Attribute("address1").Value = pnlOrderInfo.Controls["txtCustAddr1"].Text;
          element.Element("customer").Attribute("address2").Value = pnlOrderInfo.Controls["txtCustAddr2"].Text;
          element.Element("customer").Attribute("city").Value = pnlOrderInfo.Controls["txtCustCity"].Text;
          element.Element("customer").Attribute("state").Value = pnlOrderInfo.Controls["txtCustState"].Text;
          element.Element("customer").Attribute("zip").Value = pnlOrderInfo.Controls["txtCustZip"].Text;
          element.Element("shipment").Attribute("delivery_method").Value = pnlOrderInfo.Controls["txtDeliveryMethod"].Text;
          element.Element("shipment").Attribute("fname").Value = custFirstLast[0];
          element.Element("shipment").Attribute("lname").Value = custFirstLast[1];
          element.Element("shipment").Attribute("phone").Value = pnlOrderInfo.Controls["txtCustPhone"].Text;
          element.Element("shipment").Attribute("email").Value = pnlOrderInfo.Controls["txtCustEmail"].Text;
          element.Element("shipment").Attribute("address1").Value = pnlOrderInfo.Controls["txtCustAddr1"].Text;
          element.Element("shipment").Attribute("city").Value = pnlOrderInfo.Controls["txtCustCity"].Text;
          element.Element("shipment").Attribute("state").Value = pnlOrderInfo.Controls["txtCustState"].Text;
          element.Element("shipment").Attribute("zip").Value = pnlOrderInfo.Controls["txtCustZip"].Text;
        }
      }

      foreach (var checkBox in pnlOrderInfo.Controls.OfType<CheckBox>())
      {
        string chkBoxName = checkBox.Name;
        string[] arrChkBoxName = chkBoxName.Split(new Char[] { '_' });
        string i = arrChkBoxName[1];
        string productId = pnlOrderInfo.Controls["txtProductId_" + i].Text;
        string productName = pnlOrderInfo.Controls["txtProdName_" + i].Text;
        string quantity = pnlOrderInfo.Controls["txtQuantity_" + i].Text;

        var qryProducts = from orderItems in orderXml.Elements("apm_order").Elements("shipment").Elements("order_item")
                          where (string)orderItems.Attribute("product").Value == productId
                          select orderItems;
        foreach (var product in qryProducts)
        {
          product.Attribute("product").Value = productId;
          product.Attribute("name").Value = productName;
          product.Attribute("quantity").Value = quantity;
          if (product.Attribute("for_fulfillment") == null)
          {
            product.Add(new XAttribute("for_fulfillment", ""));
          }
          if (checkBox.Checked == false)
          {
            product.Attribute("for_fulfillment").Value = "false";
          }
          else
          {
            product.Attribute("for_fulfillment").Value = "true";
          }
        }
      }
      orderXml.Save(newOrderXml);
    } //end modifyOrderXml
  }
}
