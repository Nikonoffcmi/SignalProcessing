using Laba5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SignalProcessing
{
    public partial class HandlerOneForm : Form
    {
        public HandlerOne handlerOne { get; set; }

        public string nameafter;

        public HandlerOneForm(List<string> names)
        {
            InitializeComponent();
            foreach (var name in names)
                comboBox1.Items.Add(name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var name = textBox1.Text;
                var min = Convert.ToInt32(numericUpDown1.Value);
                var max = Convert.ToInt32(numericUpDown2.Value);
                nameafter = comboBox1.Text;

                handlerOne = new HandlerOne(name, min, max);
                Close();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Argument error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                DialogResult = DialogResult.None;
                
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Overflow error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                DialogResult = DialogResult.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                DialogResult = DialogResult.None;
            }        
        }
    }
}
