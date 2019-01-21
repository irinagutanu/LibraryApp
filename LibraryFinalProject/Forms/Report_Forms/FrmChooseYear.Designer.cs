namespace LibraryFinalProject.Forms.Report_Forms
{
  partial class FrmChooseYear
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
      this.txtYear = new DevExpress.XtraEditors.TextEdit();
      this.groupYear = new DevExpress.XtraEditors.GroupControl();
      this.btnGenerateReport = new DevExpress.XtraEditors.SimpleButton();
      this.labelYear = new DevExpress.XtraEditors.LabelControl();
      ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupYear)).BeginInit();
      this.groupYear.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtYear
      // 
      this.txtYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtYear.Location = new System.Drawing.Point(50, 9);
      this.txtYear.Name = "txtYear";
      this.txtYear.Size = new System.Drawing.Size(180, 20);
      this.txtYear.TabIndex = 0;
      // 
      // groupYear
      // 
      this.groupYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupYear.Controls.Add(this.btnGenerateReport);
      this.groupYear.Controls.Add(this.labelYear);
      this.groupYear.Controls.Add(this.txtYear);
      this.groupYear.Location = new System.Drawing.Point(2, 3);
      this.groupYear.Name = "groupYear";
      this.groupYear.ShowCaption = false;
      this.groupYear.Size = new System.Drawing.Size(235, 67);
      this.groupYear.TabIndex = 1;
      this.groupYear.Text = "groupControl1";
      // 
      // btnGenerateReport
      // 
      this.btnGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnGenerateReport.Location = new System.Drawing.Point(129, 35);
      this.btnGenerateReport.Name = "btnGenerateReport";
      this.btnGenerateReport.Size = new System.Drawing.Size(95, 23);
      this.btnGenerateReport.TabIndex = 2;
      this.btnGenerateReport.Text = "Generate Report";
      this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
      // 
      // labelYear
      // 
      this.labelYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelYear.Location = new System.Drawing.Point(10, 12);
      this.labelYear.Name = "labelYear";
      this.labelYear.Size = new System.Drawing.Size(22, 13);
      this.labelYear.TabIndex = 1;
      this.labelYear.Text = "Year";
      // 
      // FrmChooseYear
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(238, 72);
      this.Controls.Add(this.groupYear);
      this.Name = "FrmChooseYear";
      this.Text = "Books Report";
      ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupYear)).EndInit();
      this.groupYear.ResumeLayout(false);
      this.groupYear.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.TextEdit txtYear;
    private DevExpress.XtraEditors.GroupControl groupYear;
    private DevExpress.XtraEditors.LabelControl labelYear;
    private DevExpress.XtraEditors.SimpleButton btnGenerateReport;
  }
}