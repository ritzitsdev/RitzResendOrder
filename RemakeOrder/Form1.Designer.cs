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
      this.SuspendLayout();
      // 
      // lblOrderNum
      // 
      this.lblOrderNum.AutoSize = true;
      this.lblOrderNum.Location = new System.Drawing.Point(3, 13);
      this.lblOrderNum.Name = "lblOrderNum";
      this.lblOrderNum.Size = new System.Drawing.Size(119, 13);
      this.lblOrderNum.TabIndex = 0;
      this.lblOrderNum.Text = "Enter an Order Number:";
      // 
      // txtOrderNum
      // 
      this.txtOrderNum.Location = new System.Drawing.Point(122, 7);
      this.txtOrderNum.Name = "txtOrderNum";
      this.txtOrderNum.Size = new System.Drawing.Size(100, 20);
      this.txtOrderNum.TabIndex = 1;
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(229, 5);
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
      this.pnlOrderInfo.Location = new System.Drawing.Point(6, 40);
      this.pnlOrderInfo.Name = "pnlOrderInfo";
      this.pnlOrderInfo.Size = new System.Drawing.Size(327, 272);
      this.pnlOrderInfo.TabIndex = 3;
      // 
      // btnRemake
      // 
      this.btnRemake.Location = new System.Drawing.Point(32, 328);
      this.btnRemake.Name = "btnRemake";
      this.btnRemake.Size = new System.Drawing.Size(190, 30);
      this.btnRemake.TabIndex = 4;
      this.btnRemake.Text = "Save Changes && Remake Order";
      this.btnRemake.UseVisualStyleBackColor = true;
      this.btnRemake.Click += new System.EventHandler(this.btnRemake_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(228, 328);
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
      this.lblOrderPath.Location = new System.Drawing.Point(3, 315);
      this.lblOrderPath.Name = "lblOrderPath";
      this.lblOrderPath.Size = new System.Drawing.Size(0, 13);
      this.lblOrderPath.TabIndex = 6;
      this.lblOrderPath.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(338, 370);
      this.Controls.Add(this.lblOrderPath);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnRemake);
      this.Controls.Add(this.pnlOrderInfo);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.txtOrderNum);
      this.Controls.Add(this.lblOrderNum);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Resend an Order";
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
  }
}

