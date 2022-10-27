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
    public partial class HandlerTwoForm : Form
    {
        public HandlerTwo handlerTwo;

        public string nameafter;

        public HandlerTwoForm(List<string> names)
        {
            InitializeComponent();
            foreach (var name in names)
                comboBox1.Items.Add(name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var name = textBox4.Text;
                var average = Convert.ToInt32(numericUpDown1.Value);
                nameafter = comboBox1.Text;

                handlerTwo = new HandlerTwo(name, average);
                Close();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Argument Out Of Range error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                DialogResult = DialogResult.Cancel;
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
