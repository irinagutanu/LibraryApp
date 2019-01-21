namespace LibraryFinalProject.Forms.Report_Forms
{
  partial class FrmChooseNumber
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
      this.groupNumber = new DevExpress.XtraEditors.GroupControl();
      this.btnNumber = new DevExpress.XtraEditors.SimpleButton();
      this.labelNumber = new DevExpress.XtraEditors.LabelControl();
      this.txtNumber = new DevExpress.XtraEditors.TextEdit();
      ((System.ComponentModel.ISupportInitialize)(this.groupNumber)).BeginInit();
      this.groupNumber.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // groupNumber
      // 
      this.groupNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupNumber.Controls.Add(this.btnNumber);
      this.groupNumber.Controls.Add(this.labelNumber);
      this.groupNumber.Controls.Add(this.txtNumber);
      this.groupNumber.Location = new System.Drawing.Point(2, 3);
      this.groupNumber.Name = "groupNumber";
      this.groupNumber.ShowCaption = false;
      this.groupNumber.Size = new System.Drawing.Size(235, 67);
      this.groupNumber.TabIndex = 0;
      // 
      // btnNumber
      // 
      this.btnNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnNumber.Location = new System.Drawing.Point(129, 35);
      this.btnNumber.Name = "btnNumber";
      this.btnNumber.Size = new System.Drawing.Size(95, 23);
      this.btnNumber.TabIndex = 2;
      this.btnNumber.Text = "Generate Report";
      this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
      // 
      // labelNumber
      // 
      this.labelNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelNumber.Location = new System.Drawing.Point(6, 10);
      this.labelNumber.Name = "labelNumber";
      this.labelNumber.Size = new System.Drawing.Size(37, 13);
      this.labelNumber.TabIndex = 1;
      this.labelNumber.Text = "Number";
      // 
      // txtNumber
      // 
      this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtNumber.Location = new System.Drawing.Point(50, 9);
      this.txtNumber.Name = "txtNumber";
      this.txtNumber.Size = new System.Drawing.Size(180, 20);
      this.txtNumber.TabIndex = 0;
      // 
      // FrmChooseNumber
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(238, 72);
      this.Controls.Add(this.groupNumber);
      this.Name = "FrmChooseNumber";
      this.Text = "Last Books Report";
      ((System.ComponentModel.ISupportInitialize)(this.groupNumber)).EndInit();
      this.groupNumber.ResumeLayout(false);
      this.groupNumber.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.GroupControl groupNumber;
    private DevExpress.XtraEditors.TextEdit txtNumber;
    private DevExpress.XtraEditors.LabelControl labelNumber;
    private DevExpress.XtraEditors.SimpleButton btnNumber;
  }
}