using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace RemakeOrder
{
  public partial class ConfigFolders : Form
  {
    public ConfigFolders()
    {
      InitializeComponent();
    }

    private void ConfigFolders_Load(object sender, EventArgs e)
    {
      showWatched();
    }

    private void showWatched()
    {
      lBoxWatched.Items.Clear();
      string pathSettingsXml = @"C:\Program Files\ITS\RemakeOrder\remakeorder.xml";

      if(!File.Exists(pathSettingsXml)){createSettingsXml();}

      XDocument settingsXml = XDocument.Load(pathSettingsXml);
      var qrySettingsXml = from locations in settingsXml.Elements("folder_paths").Elements("search_folders").Elements("location")
                           select locations;
      foreach (var location in qrySettingsXml)
      {
        string availability = "          ... Currently Unavailable.";
        if (Directory.Exists(location.Value))
        {
          availability = "          ... Available";
        }
        lBoxWatched.Items.Add(location.Value + availability);
      }

      var qryPrintFolder = from printFolder in settingsXml.Elements("folder_paths").Elements("print_folder").Elements("location")
                           select printFolder;
      foreach (var location in qryPrintFolder)
      {
        txtPrintFolder.Text = location.Value;
      }
    } //end showWatched

    private void createSettingsXml()
    {
      XDocument xDoc = new XDocument(
        new XDeclaration("1.0", "windows-1252", null),
          new XElement("folder_paths",
            new XElement("search_folders"),
            new XElement("print_folder")));
      xDoc.Save(@"C:\Program Files\ITS\RemakeOrder\remakeorder.xml");
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      string newWatchItem = string.Empty;
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.ShowNewFolderButton = false;
      folderBrowserDialog.Description = "Select a folder to search.";
      DialogResult dialogResult = folderBrowserDialog.ShowDialog();

      if (dialogResult == DialogResult.OK)
      {
        newWatchItem = folderBrowserDialog.SelectedPath;
        Environment.SpecialFolder root = folderBrowserDialog.RootFolder;
        saveWatchItem(newWatchItem);
      }
    } //end btnAdd_Click

    private void saveWatchItem(string newWatchItem)
    {
      string pathSettingsXml = @"C:\Program Files\ITS\RemakeOrder\remakeorder.xml";
      XDocument settingsXml = XDocument.Load(pathSettingsXml);
      var qrySettingsXml = from locations in settingsXml.Elements("folder_paths").Elements("search_folders")
                           select locations;
      foreach (XElement location in qrySettingsXml)
      {
        location.Add(new XElement("location", newWatchItem));
      }
      settingsXml.Save(pathSettingsXml);
      showWatched();
    } //end saveWatchedItem

    private void btnRemove_Click(object sender, EventArgs e)
    {
      if (lBoxWatched.SelectedItem == null)
      {
        MessageBox.Show("Please select a folder to remove.");
        return;
      }
      else
      {
        string selectedItem = Convert.ToString(lBoxWatched.SelectedItem);
        string[] selectedItemSplit = selectedItem.Split('.');
        string removeItem = selectedItemSplit[0].Trim();
        string pathSettingsXml = @"C:\Program Files\ITS\RemakeOrder\remakeorder.xml";

        XDocument settingsXml = XDocument.Load(pathSettingsXml);
        var qrySettingsXml = from locations in settingsXml.Elements("folder_paths").Elements("search_folders").Elements("location")
                             where (string)locations.Value == removeItem
                             select locations;
        var folders = qrySettingsXml.ToList();
        foreach (XElement location in folders)
        {
          location.Remove();
        }
        lBoxWatched.Items.Remove(lBoxWatched.SelectedItem);
        settingsXml.Save(pathSettingsXml);
      }
    } //end btnRemove_Click

    private void btnOK_Click(object sender, EventArgs e)
    {
      this.Close();
    } //end btnOK_Click

    private void btnAddPF_Click(object sender, EventArgs e)
    {
      string printFolder = string.Empty;
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.ShowNewFolderButton = false;
      folderBrowserDialog.Description = "Select the print folder.";
      DialogResult dialogResult = folderBrowserDialog.ShowDialog();

      if (dialogResult == DialogResult.OK)
      {
        printFolder = folderBrowserDialog.SelectedPath;
        Environment.SpecialFolder root = folderBrowserDialog.RootFolder;
        savePrintFolder(printFolder);
      }
    } //end btnAddPF_Click

    private void savePrintFolder(string printFolder)
    {
      string pathSettingsXml = @"C:\Program Files\ITS\RemakeOrder\remakeorder.xml";
      XDocument settingsXml = XDocument.Load(pathSettingsXml);
      var qrySettingsXml = from folders in settingsXml.Elements("folder_paths").Elements("print_folder")
                           select folders;
      foreach (XElement printLocation in qrySettingsXml)
      {
        if (printLocation.Element("location") == null)
        {
          printLocation.Add(new XElement("location", printFolder));
        }
        else
        {
          printLocation.Element("lcoation").Value = printFolder;
        }
      }
      settingsXml.Save(pathSettingsXml);
      showWatched();
    } //end savePrintFolder
  }
}
