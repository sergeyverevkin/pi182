namespace pi182_20190925_WinForms
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
      this.btnSet = new System.Windows.Forms.Button();
      this.labClock1 = new System.Windows.Forms.Label();
      this.labClock2 = new System.Windows.Forms.Label();
      this.pbClock = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pbClock)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnSet
      // 
      this.btnSet.Location = new System.Drawing.Point(467, 107);
      this.btnSet.Name = "btnSet";
      this.btnSet.Size = new System.Drawing.Size(75, 23);
      this.btnSet.TabIndex = 0;
      this.btnSet.Text = "Начать";
      this.btnSet.UseVisualStyleBackColor = true;
      this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
      // 
      // labClock1
      // 
      this.labClock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labClock1.Location = new System.Drawing.Point(117, 107);
      this.labClock1.Name = "labClock1";
      this.labClock1.Size = new System.Drawing.Size(360, 81);
      this.labClock1.TabIndex = 1;
      // 
      // labClock2
      // 
      this.labClock2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labClock2.Location = new System.Drawing.Point(93, 224);
      this.labClock2.Name = "labClock2";
      this.labClock2.Size = new System.Drawing.Size(360, 81);
      this.labClock2.TabIndex = 2;
      // 
      // pbClock
      // 
      this.pbClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pbClock.Location = new System.Drawing.Point(548, 107);
      this.pbClock.Name = "pbClock";
      this.pbClock.Size = new System.Drawing.Size(240, 229);
      this.pbClock.TabIndex = 3;
      this.pbClock.TabStop = false;
      this.pbClock.Paint += new System.Windows.Forms.PaintEventHandler(this.pbClock_Paint);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pictureBox1.Location = new System.Drawing.Point(434, 220);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(108, 116);
      this.pictureBox1.TabIndex = 4;
      this.pictureBox1.TabStop = false;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(525, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(136, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "Газоанализатор";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(525, 41);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(136, 23);
      this.button2.TabIndex = 6;
      this.button2.Text = "Правильная форма";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(525, 70);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(136, 23);
      this.button3.TabIndex = 7;
      this.button3.Text = "шахматы";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.pbClock);
      this.Controls.Add(this.labClock2);
      this.Controls.Add(this.labClock1);
      this.Controls.Add(this.btnSet);
      this.Name = "Form1";
      this.Text = "Часы";
      ((System.ComponentModel.ISupportInitialize)(this.pbClock)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnSet;
    private System.Windows.Forms.Label labClock1;
    private System.Windows.Forms.Label labClock2;
    private System.Windows.Forms.PictureBox pbClock;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
  }
}

