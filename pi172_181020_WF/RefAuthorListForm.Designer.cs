namespace pi172_181020_WF
{
  partial class RefAuthorListForm
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.lvBooks = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.panLeft = new System.Windows.Forms.Panel();
      this.panRight = new System.Windows.Forms.Panel();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.panLeft.SuspendLayout();
      this.panRight.SuspendLayout();
      this.SuspendLayout();
      // 
      // lvBooks
      // 
      this.lvBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
      this.lvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lvBooks.FullRowSelect = true;
      this.lvBooks.GridLines = true;
      this.lvBooks.Location = new System.Drawing.Point(0, 0);
      this.lvBooks.Name = "lvBooks";
      this.lvBooks.Size = new System.Drawing.Size(437, 264);
      this.lvBooks.TabIndex = 0;
      this.lvBooks.UseCompatibleStateImageBehavior = false;
      this.lvBooks.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Номер";
      this.columnHeader1.Width = 48;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "ФИО";
      this.columnHeader2.Width = 102;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Дата рождения";
      this.columnHeader3.Width = 85;
      // 
      // panLeft
      // 
      this.panLeft.Controls.Add(this.lvBooks);
      this.panLeft.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panLeft.Location = new System.Drawing.Point(0, 0);
      this.panLeft.Name = "panLeft";
      this.panLeft.Size = new System.Drawing.Size(437, 264);
      this.panLeft.TabIndex = 1;
      // 
      // panRight
      // 
      this.panRight.Controls.Add(this.btnDelete);
      this.panRight.Controls.Add(this.btnEdit);
      this.panRight.Controls.Add(this.btnAdd);
      this.panRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.panRight.Location = new System.Drawing.Point(437, 0);
      this.panRight.Name = "panRight";
      this.panRight.Size = new System.Drawing.Size(105, 264);
      this.panRight.TabIndex = 2;
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(16, 61);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 23);
      this.btnDelete.TabIndex = 2;
      this.btnDelete.Text = "Удалить";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.Location = new System.Drawing.Point(16, 32);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(75, 23);
      this.btnEdit.TabIndex = 1;
      this.btnEdit.Text = "Изменить";
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(16, 3);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 23);
      this.btnAdd.TabIndex = 0;
      this.btnAdd.Text = "Добавить";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // RefAuthorListForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(542, 264);
      this.Controls.Add(this.panLeft);
      this.Controls.Add(this.panRight);
      this.MinimumSize = new System.Drawing.Size(320, 193);
      this.Name = "RefAuthorListForm";
      this.Text = "Form1";
      this.panLeft.ResumeLayout(false);
      this.panRight.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListView lvBooks;
    private System.Windows.Forms.Panel panLeft;
    private System.Windows.Forms.Panel panRight;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
  }
}

