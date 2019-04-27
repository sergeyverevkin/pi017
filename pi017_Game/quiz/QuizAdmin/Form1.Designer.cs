namespace QuizAdmin
{
  partial class Form1
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
      if (disposing && (components != null)) {
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.серверToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.стартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.стопToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.серверToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // файлToolStripMenuItem
      // 
      this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
      this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
      this.файлToolStripMenuItem.Text = "Файл";
      // 
      // загрузитьToolStripMenuItem
      // 
      this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
      this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.загрузитьToolStripMenuItem.Text = "Загрузить";
      this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
      // 
      // сохранитьToolStripMenuItem
      // 
      this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
      this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.сохранитьToolStripMenuItem.Text = "Сохранить";
      this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
      // 
      // выходToolStripMenuItem
      // 
      this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
      this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.выходToolStripMenuItem.Text = "Выход";
      // 
      // серверToolStripMenuItem
      // 
      this.серверToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стартToolStripMenuItem,
            this.стопToolStripMenuItem});
      this.серверToolStripMenuItem.Name = "серверToolStripMenuItem";
      this.серверToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
      this.серверToolStripMenuItem.Text = "Сервер";
      // 
      // стартToolStripMenuItem
      // 
      this.стартToolStripMenuItem.Name = "стартToolStripMenuItem";
      this.стартToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.стартToolStripMenuItem.Text = "Старт";
      this.стартToolStripMenuItem.Click += new System.EventHandler(this.стартToolStripMenuItem_Click);
      // 
      // стопToolStripMenuItem
      // 
      this.стопToolStripMenuItem.Name = "стопToolStripMenuItem";
      this.стопToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.стопToolStripMenuItem.Text = "Стоп";
      this.стопToolStripMenuItem.Click += new System.EventHandler(this.стопToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem серверToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem стартToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem стопToolStripMenuItem;
  }
}

