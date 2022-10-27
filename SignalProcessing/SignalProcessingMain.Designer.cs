namespace SignalProcessing
{
    partial class SignalProcessingMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HandlersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HandlerOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HandlerTwoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FIleRead = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProcessSignal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HandlersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HandlersToolStripMenuItem
            // 
            this.HandlersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HandlerOneToolStripMenuItem,
            this.HandlerTwoToolStripMenuItem});
            this.HandlersToolStripMenuItem.Name = "HandlersToolStripMenuItem";
            this.HandlersToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.HandlersToolStripMenuItem.Text = "Обработчики";
            // 
            // HandlerOneToolStripMenuItem
            // 
            this.HandlerOneToolStripMenuItem.Name = "HandlerOneToolStripMenuItem";
            this.HandlerOneToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.HandlerOneToolStripMenuItem.Text = "Обработчик Тип 1";
            this.HandlerOneToolStripMenuItem.Click += new System.EventHandler(this.HandlerOneToolStripMenuItem_Click);
            // 
            // HandlerTwoToolStripMenuItem
            // 
            this.HandlerTwoToolStripMenuItem.Name = "HandlerTwoToolStripMenuItem";
            this.HandlerTwoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.HandlerTwoToolStripMenuItem.Text = "Обработчик Тип 2";
            this.HandlerTwoToolStripMenuItem.Click += new System.EventHandler(this.HandlerTwoToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 340);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имена обработчиков в порядке очереди";
            // 
            // FIleRead
            // 
            this.FIleRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FIleRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIleRead.Location = new System.Drawing.Point(420, 98);
            this.FIleRead.Name = "FIleRead";
            this.FIleRead.Size = new System.Drawing.Size(159, 29);
            this.FIleRead.TabIndex = 3;
            this.FIleRead.Text = "Файл со значениями";
            this.FIleRead.UseVisualStyleBackColor = true;
            this.FIleRead.Click += new System.EventHandler(this.FileRead_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(420, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(429, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выходные значения сигнала:";
            // 
            // ProcessSignal
            // 
            this.ProcessSignal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessSignal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProcessSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcessSignal.Location = new System.Drawing.Point(640, 98);
            this.ProcessSignal.Name = "ProcessSignal";
            this.ProcessSignal.Size = new System.Drawing.Size(148, 29);
            this.ProcessSignal.TabIndex = 6;
            this.ProcessSignal.Text = "Обработать сигнал";
            this.ProcessSignal.UseVisualStyleBackColor = true;
            this.ProcessSignal.Click += new System.EventHandler(this.ProcessSignal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(429, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.InitialDirectory = "C:\\Users\\Марина\\OneDrive\\Рабочий стол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(416, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Входные значения сигнала:";
            // 
            // SignalProcessingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProcessSignal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FIleRead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SignalProcessingMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HandlersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HandlerOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HandlerTwoToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FIleRead;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ProcessSignal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
    }
}

