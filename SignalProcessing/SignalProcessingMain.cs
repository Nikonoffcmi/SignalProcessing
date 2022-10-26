using Laba5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace SignalProcessing
{
    public partial class SignalProcessingMain : Form
    {

        HandlerComposite handlers;

        string filePath;

        public SignalProcessingMain()
        {
            InitializeComponent();
            handlers = new HandlerComposite();
            label3.Text = "";
            label2.Text = "";
            filePath = "SignalProcessing.txt";
        }

        private void HandlerOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CatalogHandlerOne = new Catalog<List<HandlerOne>, HandlerOne>(handlers.GetHandlerOne(), handlers);
            if (CatalogHandlerOne.ShowDialog() == DialogResult.Cancel)
                UpdateList();
        }

        private void HandlerTwoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CatalogHandlerTwo = new Catalog<List<HandlerTwo>, HandlerTwo>(handlers.GetHandlerTwo(), handlers);
            if (CatalogHandlerTwo.ShowDialog() == DialogResult.Cancel)
                UpdateList();
        }

        private void UpdateList()
        {
            listBox1.Items.Clear();
            var i = 1;
            foreach (var name in handlers.GetNames())
                listBox1.Items.Add(i++.ToString() + ". " + name);
        }

        private void FileRead_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };
            if (file.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(file.FileName);
                    textBox1.Text = (sr.ReadToEnd());
                    filePath = file.FileName;
                    sr.Close();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }

        }

        private void ProcessSignal_Click(object sender, EventArgs e)
        {
            try
            {
                var numbers = textBox1.Text
                .Split(new char[] { ' ' })
                .Where(n => n != "")
                .Select(n => double.Parse(n))
                .ToList<double>();

                handlers.RunProcessing(numbers);

                label3.Text = "";
                foreach (var number in numbers)
                    label3.Text += number.ToString() + " ";

                
                var sw = new StreamWriter(filePath);
                sw.WriteLine(label3.Text.Remove(label3.Text.Length - 1));
                sw.Close();
                label2.Text = "Выходные значения сигнала:";
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Format error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"Format error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
            }

        }
    }
}
