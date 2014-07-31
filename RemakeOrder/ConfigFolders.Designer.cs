namespace RemakeOrder
{
  partial class ConfigFolders
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lBoxWatched = new System.Windows.Forms.ListBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnRemove = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.lblSearchFolders = new System.Windows.Forms.Label();
      this.lblPrintFolder = new System.Windows.Forms.Label();
      this.txtPrintFolder = new System.Windows.Forms.TextBox();
      this.btnAddPF = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lBoxWatched
      // 
      this.lBoxWatched.FormattingEnabled = true;
      this.lBoxWatched.Location = new System.Drawing.Point(13, 28);
      this.lBoxWatched.Name = "lBoxWatched";
      this.lBoxWatched.Size = new System.Drawing.Size(363, 108);
      this.lBoxWatched.TabIndex = 0;
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(13, 144);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 23);
      this.btnAdd.TabIndex = 1;
      this.btnAdd.Text = "Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnRemove
      // 
      this.btnRemove.Location = new System.Drawing.Point(95, 144);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(75, 23);
      this.btnRemove.TabIndex = 2;
      this.btnRemove.Text = "Remove";
      this.btnRemove.UseVisualStyleBackColor = true;
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // btnOK
      // 
      this.btnOK.Location = new System.Drawing.Point(300, 263);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 3;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // lblSearchFolders
      // 
      this.lblSearchFolders.AutoSize = true;
      this.lblSearchFolders.Location = new System.Drawing.Point(13, 13);
      this.lblSearchFolders.Name = "lblSearchFolders";
      this.lblSearchFolders.Size = new System.Drawing.Size(297, 13);
      this.lblSearchFolders.TabIndex = 4;
      this.lblSearchFolders.Text = "The folders listed below will be searched for orders to remake.";
      // 
      // lblPrintFolder
      // 
      this.lblPrintFolder.AutoSize = true;
      this.lblPrintFolder.Location = new System.Drawing.Point(16, 184);
      this.lblPrintFolder.Name = "lblPrintFolder";
      this.lblPrintFolder.Size = new System.Drawing.Size(292, 13);
      this.lblPrintFolder.TabIndex = 5;
      this.lblPrintFolder.Text = "The folder below is where the order will be sent for remaking.";
      // 
      // txtPrintFolder
      // 
      this.txtPrintFolder.Location = new System.Drawing.Point(13, 201);
      this.txtPrintFolder.Name = "txtPrintFolder";
      this.txtPrintFolder.Size = new System.Drawing.Size(362, 20);
      this.txtPrintFolder.TabIndex = 6;
      // 
      // btnAddPF
      // 
      this.btnAddPF.Location = new System.Drawing.Point(13, 228);
      this.btnAddPF.Name = "btnAddPF";
      this.btnAddPF.Size = new System.Drawing.Size(75, 23);
      this.btnAddPF.TabIndex = 7;
      this.btnAddPF.Text = "Add";
      this.btnAddPF.UseVisualStyleBackColor = true;
      this.btnAddPF.Click += new System.EventHandler(this.btnAddPF_Click);
      // 
      // ConfigFolders
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(388, 293);
      this.Controls.Add(this.btnAddPF);
      this.Controls.Add(this.txtPrintFolder);
      this.Controls.Add(this.lblPrintFolder);
      this.Controls.Add(this.lblSearchFolders);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.btnRemove);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.lBoxWatched);
      this.Name = "ConfigFolders";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Search Folders";
      this.Load += new System.EventHandler(this.ConfigFolders_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lBoxWatched;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Label lblSearchFolders;
    private System.Windows.Forms.Label lblPrintFolder;
    private System.Windows.Forms.TextBox txtPrintFolder;
    private System.Windows.Forms.Button btnAddPF;
  }
}