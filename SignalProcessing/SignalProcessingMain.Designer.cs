﻿namespace SignalProcessing
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
            this.HandlerOneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HandlerOneToolStripMenuItem.Text = "Обработчик Тип 1";
            this.HandlerOneToolStripMenuItem.Click += new System.EventHandler(this.HandlerOneToolStripMenuItem_Click);
            // 
            // HandlerTwoToolStripMenuItem
            // 
            this.HandlerTwoToolStripMenuItem.Name = "HandlerTwoToolStripMenuItem";
            this.HandlerTwoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HandlerTwoToolStripMenuItem.Text = "Обработчик Тип 2";
            this.HandlerTwoToolStripMenuItem.Click += new System.EventHandler(this.HandlerTwoToolStripMenuItem_Click);
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
    }
}

