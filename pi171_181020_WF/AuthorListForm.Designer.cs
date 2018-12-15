namespace pi171_181020_WF
{
  partial class AuthorListForm
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
      this.btnEdit = new System.Windows.Forms.Button();
      this.lvAuthorList = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.panLeft = new System.Windows.Forms.Panel();
      this.panRight = new System.Windows.Forms.Panel();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.panLeft.SuspendLayout();
      this.panRight.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnEdit
      // 
      this.btnEdit.Location = new System.Drawing.Point(11, 12);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(131, 24);
      this.btnEdit.TabIndex = 0;
      this.btnEdit.Text = "Изменить";
      this.btnEdit.UseVisualStyleBackColor = true;
      // 
      // lvAuthorList
      // 
      this.lvAuthorList.BackColor = System.Drawing.SystemColors.Window;
      this.lvAuthorList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
      this.lvAuthorList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lvAuthorList.FullRowSelect = true;
      this.lvAuthorList.GridLines = true;
      this.lvAuthorList.Location = new System.Drawing.Point(0, 0);
      this.lvAuthorList.MultiSelect = false;
      this.lvAuthorList.Name = "lvAuthorList";
      this.lvAuthorList.Size = new System.Drawing.Size(372, 221);
      this.lvAuthorList.TabIndex = 1;
      this.lvAuthorList.UseCompatibleStateImageBehavior = false;
      this.lvAuthorList.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "№ п/п";
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "ФИО";
      this.columnHeader2.Width = 213;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Год рождения";
      this.columnHeader3.Width = 87;
      // 
      // panLeft
      // 
      this.panLeft.Controls.Add(this.lvAuthorList);
      this.panLeft.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panLeft.Location = new System.Drawing.Point(0, 0);
      this.panLeft.Name = "panLeft";
      this.panLeft.Size = new System.Drawing.Size(372, 221);
      this.panLeft.TabIndex = 4;
      // 
      // panRight
      // 
      this.panRight.Controls.Add(this.btnAdd);
      this.panRight.Controls.Add(this.btnDelete);
      this.panRight.Controls.Add(this.btnEdit);
      this.panRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.panRight.Location = new System.Drawing.Point(372, 0);
      this.panRight.Name = "panRight";
      this.panRight.Size = new System.Drawing.Size(154, 221);
      this.panRight.TabIndex = 5;
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(11, 70);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(131, 23);
      this.btnAdd.TabIndex = 2;
      this.btnAdd.Text = "Добавить";
      this.btnAdd.UseVisualStyleBackColor = true;
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(11, 41);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(131, 23);
      this.btnDelete.TabIndex = 1;
      this.btnDelete.Text = "Удалить";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // AuthorListForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(526, 221);
      this.Controls.Add(this.panLeft);
      this.Controls.Add(this.panRight);
      this.Name = "AuthorListForm";
      this.Text = "AuthorListForm";
      this.panLeft.ResumeLayout(false);
      this.panRight.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.ListView lvAuthorList;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.Panel panLeft;
    private System.Windows.Forms.Panel panRight;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnDelete;
  }
}