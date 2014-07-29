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
      this.lblOrderInfo = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
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
      // lblOrderInfo
      // 
      this.lblOrderInfo.AutoSize = true;
      this.lblOrderInfo.Location = new System.Drawing.Point(12, 51);
      this.lblOrderInfo.Name = "lblOrderInfo";
      this.lblOrderInfo.Size = new System.Drawing.Size(0, 13);
      this.lblOrderInfo.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 68);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "label1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 88);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "label2";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(312, 269);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lblOrderInfo);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.txtOrderNum);
      this.Controls.Add(this.lblOrderNum);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblOrderNum;
    private System.Windows.Forms.TextBox txtOrderNum;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Label lblOrderInfo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}

