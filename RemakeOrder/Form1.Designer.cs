namespace RemakeOrder
{
  partial class Form1
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
      this.lblOrderNum = new System.Windows.Forms.Label();
      this.txtOrderNum = new System.Windows.Forms.TextBox();
      this.btnSearch = new System.Windows.Forms.Button();
      this.pnlOrderInfo = new System.Windows.Forms.Panel();
      this.btnRemake = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.lblOrderPath = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.searchFoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblOrderNum
      // 
      this.lblOrderNum.AutoSize = true;
      this.lblOrderNum.Location = new System.Drawing.Point(3, 34);
      this.lblOrderNum.Name = "lblOrderNum";
      this.lblOrderNum.Size = new System.Drawing.Size(119, 13);
      this.lblOrderNum.TabIndex = 0;
      this.lblOrderNum.Text = "Enter an Order Number:";
      // 
      // txtOrderNum
      // 
      this.txtOrderNum.Location = new System.Drawing.Point(122, 28);
      this.txtOrderNum.Name = "txtOrderNum";
      this.txtOrderNum.Size = new System.Drawing.Size(100, 20);
      this.txtOrderNum.TabIndex = 1;
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(229, 26);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 23);
      this.btnSearch.TabIndex = 2;
      this.btnSearch.Text = "Search";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // pnlOrderInfo
      // 
      this.pnlOrderInfo.AutoScroll = true;
      this.pnlOrderInfo.Location = new System.Drawing.Point(6, 61);
      this.pnlOrderInfo.Name = "pnlOrderInfo";
      this.pnlOrderInfo.Size = new System.Drawing.Size(327, 272);
      this.pnlOrderInfo.TabIndex = 3;
      // 
      // btnRemake
      // 
      this.btnRemake.Location = new System.Drawing.Point(32, 374);
      this.btnRemake.Name = "btnRemake";
      this.btnRemake.Size = new System.Drawing.Size(190, 30);
      this.btnRemake.TabIndex = 4;
      this.btnRemake.Text = "Save Changes && Remake Order";
      this.btnRemake.UseVisualStyleBackColor = true;
      this.btnRemake.Click += new System.EventHandler(this.btnRemake_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(228, 374);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 30);
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // lblOrderPath
      // 
      this.lblOrderPath.AutoSize = true;
      this.lblOrderPath.Location = new System.Drawing.Point(10, 345);
      this.lblOrderPath.Name = "lblOrderPath";
      this.lblOrderPath.Size = new System.Drawing.Size(0, 13);
      this.lblOrderPath.TabIndex = 6;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchFoldersToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(338, 24);
      this.menuStrip1.TabIndex = 7;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // searchFoldersToolStripMenuItem
      // 
      this.searchFoldersToolStripMenuItem.Name = "searchFoldersToolStripMenuItem";
      this.searchFoldersToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
      this.searchFoldersToolStripMenuItem.Text = "Set Search Folders";
      this.searchFoldersToolStripMenuItem.Click += new System.EventHandler(this.searchFoldersToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(338, 414);
      this.Controls.Add(this.lblOrderPath);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnRemake);
      this.Controls.Add(this.pnlOrderInfo);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.txtOrderNum);
      this.Controls.Add(this.lblOrderNum);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Resend an Order";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblOrderNum;
    private System.Windows.Forms.TextBox txtOrderNum;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Panel pnlOrderInfo;
    private System.Windows.Forms.Button btnRemake;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Label lblOrderPath;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem searchFoldersToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
  }
}

