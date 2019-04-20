namespace TooHotApp
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
      this.components = new System.ComponentModel.Container();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btn1 = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.Red;
      this.panel1.Controls.Add(this.btn1);
      this.panel1.Location = new System.Drawing.Point(32, 24);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(111, 83);
      this.panel1.TabIndex = 2;
      // 
      // btn1
      // 
      this.btn1.BackColor = System.Drawing.Color.LightGray;
      this.btn1.ContextMenuStrip = this.contextMenuStrip1;
      this.btn1.Dock = System.Windows.Forms.DockStyle.Top;
      this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btn1.Location = new System.Drawing.Point(0, 0);
      this.btn1.Name = "btn1";
      this.btn1.Size = new System.Drawing.Size(111, 64);
      this.btn1.TabIndex = 1;
      this.btn1.Text = "1";
      this.btn1.UseVisualStyleBackColor = false;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.Blue;
      this.panel2.Controls.Add(this.button1);
      this.panel2.Location = new System.Drawing.Point(149, 24);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(111, 83);
      this.panel2.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.LightGray;
      this.button1.Dock = System.Windows.Forms.DockStyle.Top;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.Location = new System.Drawing.Point(0, 0);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(111, 64);
      this.button1.TabIndex = 1;
      this.button1.Text = "1";
      this.button1.UseVisualStyleBackColor = false;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(181, 136);
      this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
      this.toolStripMenuItem2.Text = "1";
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
      this.toolStripMenuItem3.Text = "3";
      this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
      // 
      // toolStripMenuItem4
      // 
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
      this.toolStripMenuItem4.Text = "5";
      // 
      // toolStripMenuItem5
      // 
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      this.toolStripMenuItem5.Size = new System.Drawing.Size(80, 22);
      this.toolStripMenuItem5.Text = "6";
      // 
      // toolStripMenuItem6
      // 
      this.toolStripMenuItem6.Name = "toolStripMenuItem6";
      this.toolStripMenuItem6.Size = new System.Drawing.Size(80, 22);
      this.toolStripMenuItem6.Text = "7";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(454, 132);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btn1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
  }
}

