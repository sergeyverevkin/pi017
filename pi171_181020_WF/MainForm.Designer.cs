namespace pi171_181020_WF
{
  partial class MainForm
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
      this.btnEdit = new System.Windows.Forms.Button();
      this.lvPerfList = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.panLeft = new System.Windows.Forms.Panel();
      this.panRight = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
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
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // lvPerfList
      // 
      this.lvPerfList.BackColor = System.Drawing.SystemColors.Window;
      this.lvPerfList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
      this.lvPerfList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lvPerfList.FullRowSelect = true;
      this.lvPerfList.GridLines = true;
      this.lvPerfList.Location = new System.Drawing.Point(0, 0);
      this.lvPerfList.MultiSelect = false;
      this.lvPerfList.Name = "lvPerfList";
      this.lvPerfList.Size = new System.Drawing.Size(550, 290);
      this.lvPerfList.TabIndex = 1;
      this.lvPerfList.UseCompatibleStateImageBehavior = false;
      this.lvPerfList.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "№ п/п";
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Наименование";
      this.columnHeader2.Width = 243;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Продолжительность";
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "Авторы";
      this.columnHeader4.Width = 122;
      // 
      // panLeft
      // 
      this.panLeft.Controls.Add(this.lvPerfList);
      this.panLeft.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panLeft.Location = new System.Drawing.Point(0, 0);
      this.panLeft.Name = "panLeft";
      this.panLeft.Size = new System.Drawing.Size(550, 290);
      this.panLeft.TabIndex = 2;
      // 
      // panRight
      // 
      this.panRight.Controls.Add(this.button1);
      this.panRight.Controls.Add(this.btnAdd);
      this.panRight.Controls.Add(this.btnDelete);
      this.panRight.Controls.Add(this.btnEdit);
      this.panRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.panRight.Location = new System.Drawing.Point(550, 0);
      this.panRight.Name = "panRight";
      this.panRight.Size = new System.Drawing.Size(154, 290);
      this.panRight.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(11, 254);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(131, 24);
      this.button1.TabIndex = 3;
      this.button1.Text = "Авторы";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(11, 70);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(131, 23);
      this.btnAdd.TabIndex = 2;
      this.btnAdd.Text = "Добавить";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(704, 290);
      this.Controls.Add(this.panLeft);
      this.Controls.Add(this.panRight);
      this.Name = "MainForm";
      this.Text = "Театральный репертуар";
      this.panLeft.ResumeLayout(false);
      this.panRight.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.ListView lvPerfList;
    private System.Windows.Forms.Panel panLeft;
    private System.Windows.Forms.Panel panRight;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.Button button1;
  }
}

