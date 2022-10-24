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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HandlersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HandlerOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddHandlerOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HandlerTwoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddHandlerTwoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.HandlerOneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddHandlerOneToolStripMenuItem});
            this.HandlerOneToolStripMenuItem.Name = "HandlerOneToolStripMenuItem";
            this.HandlerOneToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.HandlerOneToolStripMenuItem.Text = "Обработчик Тип 1";
            // 
            // AddHandlerOneToolStripMenuItem
            // 
            this.AddHandlerOneToolStripMenuItem.Name = "AddHandlerOneToolStripMenuItem";
            this.AddHandlerOneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddHandlerOneToolStripMenuItem.Text = "Добавить";
            this.AddHandlerOneToolStripMenuItem.Click += new System.EventHandler(this.AddHandlerOneToolStripMenuItem_Click);
            // 
            // HandlerTwoToolStripMenuItem
            // 
            this.HandlerTwoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddHandlerTwoToolStripMenuItem1});
            this.HandlerTwoToolStripMenuItem.Name = "HandlerTwoToolStripMenuItem";
            this.HandlerTwoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.HandlerTwoToolStripMenuItem.Text = "Обработчик Тип 2";
            // 
            // AddHandlerTwoToolStripMenuItem1
            // 
            this.AddHandlerTwoToolStripMenuItem1.Name = "AddHandlerTwoToolStripMenuItem1";
            this.AddHandlerTwoToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.AddHandlerTwoToolStripMenuItem1.Text = "Добавить";
            this.AddHandlerTwoToolStripMenuItem1.Click += new System.EventHandler(this.AddHandlerTwoToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SignalProcessingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.ToolStripMenuItem AddHandlerOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddHandlerTwoToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

