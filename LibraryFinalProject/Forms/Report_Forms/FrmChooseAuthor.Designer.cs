namespace LibraryFinalProject.Forms.Report_Forms
{
  partial class FrmChooseAuthor
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
      this.groupAuthor = new DevExpress.XtraEditors.GroupControl();
      this.lookUpAuthor = new DevExpress.XtraEditors.LookUpEdit();
      this.labelAuthor = new DevExpress.XtraEditors.LabelControl();
      this.btnAuthor = new DevExpress.XtraEditors.SimpleButton();
      this.libraryDataSet1 = new LibraryFinalProject.Model.LibraryDataSet();
      ((System.ComponentModel.ISupportInitialize)(this.groupAuthor)).BeginInit();
      this.groupAuthor.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpAuthor.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
      this.SuspendLayout();
      // 
      // groupAuthor
      // 
      this.groupAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupAuthor.Controls.Add(this.btnAuthor);
      this.groupAuthor.Controls.Add(this.labelAuthor);
      this.groupAuthor.Controls.Add(this.lookUpAuthor);
      this.groupAuthor.Location = new System.Drawing.Point(2, 0);
      this.groupAuthor.Name = "groupAuthor";
      this.groupAuthor.ShowCaption = false;
      this.groupAuthor.Size = new System.Drawing.Size(234, 67);
      this.groupAuthor.TabIndex = 0;
      this.groupAuthor.Text = "groupControl1";
      // 
      // lookUpAuthor
      // 
      this.lookUpAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lookUpAuthor.Location = new System.Drawing.Point(50, 9);
      this.lookUpAuthor.Name = "lookUpAuthor";
      this.lookUpAuthor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpAuthor.Properties.NullText = "Select Author...";
      this.lookUpAuthor.Properties.ValueMember = "Id";
      this.lookUpAuthor.Size = new System.Drawing.Size(180, 20);
      this.lookUpAuthor.TabIndex = 0;
      this.lookUpAuthor.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.lookUpAuthor_CustomDisplayText);
      // 
      // labelAuthor
      // 
      this.labelAuthor.Location = new System.Drawing.Point(5, 12);
      this.labelAuthor.Name = "labelAuthor";
      this.labelAuthor.Size = new System.Drawing.Size(33, 13);
      this.labelAuthor.TabIndex = 1;
      this.labelAuthor.Text = "Author";
      // 
      // btnAuthor
      // 
      this.btnAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAuthor.Location = new System.Drawing.Point(129, 35);
      this.btnAuthor.Name = "btnAuthor";
      this.btnAuthor.Size = new System.Drawing.Size(95, 23);
      this.btnAuthor.TabIndex = 2;
      this.btnAuthor.Text = "Generate Report";
      this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
      // 
      // libraryDataSet1
      // 
      this.libraryDataSet1.DataSetName = "LibraryDataSet";
      this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // FrmChooseAuthor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(238, 69);
      this.Controls.Add(this.groupAuthor);
      this.Name = "FrmChooseAuthor";
      this.Text = "Author Report";
      ((System.ComponentModel.ISupportInitialize)(this.groupAuthor)).EndInit();
      this.groupAuthor.ResumeLayout(false);
      this.groupAuthor.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpAuthor.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.GroupControl groupAuthor;
    private DevExpress.XtraEditors.LookUpEdit lookUpAuthor;
    private DevExpress.XtraEditors.LabelControl labelAuthor;
    private DevExpress.XtraEditors.SimpleButton btnAuthor;
    private Model.LibraryDataSet libraryDataSet1;
  }
}