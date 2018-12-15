namespace pi172_181020_WF
{
  partial class BookForm
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
      this.panBlank = new System.Windows.Forms.Panel();
      this.nupYear = new System.Windows.Forms.NumericUpDown();
      this.edTitle = new System.Windows.Forms.TextBox();
      this.panButtons = new System.Windows.Forms.Panel();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOk = new System.Windows.Forms.Button();
      this.panBlank.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nupYear)).BeginInit();
      this.panButtons.SuspendLayout();
      this.SuspendLayout();
      // 
      // panBlank
      // 
      this.panBlank.Controls.Add(this.nupYear);
      this.panBlank.Controls.Add(this.edTitle);
      this.panBlank.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panBlank.Location = new System.Drawing.Point(0, 0);
      this.panBlank.Name = "panBlank";
      this.panBlank.Size = new System.Drawing.Size(451, 174);
      this.panBlank.TabIndex = 0;
      // 
      // nupYear
      // 
      this.nupYear.Location = new System.Drawing.Point(82, 50);
      this.nupYear.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
      this.nupYear.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
      this.nupYear.Name = "nupYear";
      this.nupYear.Size = new System.Drawing.Size(61, 20);
      this.nupYear.TabIndex = 1;
      this.nupYear.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
      // 
      // edTitle
      // 
      this.edTitle.Location = new System.Drawing.Point(82, 24);
      this.edTitle.Name = "edTitle";
      this.edTitle.Size = new System.Drawing.Size(279, 20);
      this.edTitle.TabIndex = 0;
      // 
      // panButtons
      // 
      this.panButtons.Controls.Add(this.btnCancel);
      this.panButtons.Controls.Add(this.btnOk);
      this.panButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panButtons.Location = new System.Drawing.Point(0, 174);
      this.panButtons.Name = "panButtons";
      this.panButtons.Size = new System.Drawing.Size(451, 37);
      this.panButtons.TabIndex = 1;
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(367, 6);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Отмена";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnOk
      // 
      this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOk.Location = new System.Drawing.Point(286, 6);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(75, 23);
      this.btnOk.TabIndex = 0;
      this.btnOk.Text = "OK";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // BookForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(451, 211);
      this.Controls.Add(this.panBlank);
      this.Controls.Add(this.panButtons);
      this.Name = "BookForm";
      this.Text = "[Название книги]";
      this.panBlank.ResumeLayout(false);
      this.panBlank.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nupYear)).EndInit();
      this.panButtons.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panBlank;
    private System.Windows.Forms.Panel panButtons;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.TextBox edTitle;
    private System.Windows.Forms.NumericUpDown nupYear;
  }
}