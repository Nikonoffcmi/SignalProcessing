using Laba5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalProcessing
{
    public partial class Catalog<T1, T2> : Form
        where T2 : class
    {
        public HandlerComposite handlers;

        public Catalog(T1 set, HandlerComposite handlers)
        {
            InitializeComponent();
            dataGridView1.DataSource = set;
            this.handlers = handlers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (typeof(T2) == typeof(HandlerOne))
                {
                    var ho = new HandlerOneForm(handlers.GetNames());
                    if (ho.ShowDialog() == DialogResult.OK)
                    {
                        if (ho.nameafter != "")
                            handlers.AddHandlerByName(ho.handlerOne, ho.nameafter);
                        else
                            handlers.AddHandlerAtTheEnd(ho.handlerOne);
                        dataGridView1.DataSource = handlers.GetHandlerOne();
                    }
                }
                else if (typeof(T2) == typeof(HandlerTwo))
                {
                    var ht = new HandlerTwoForm(handlers.GetNames());
                    if (ht.ShowDialog() == DialogResult.OK)
                    {
                        if (ht.nameafter != "")
                            handlers.AddHandlerByName(ht.handlerTwo, ht.nameafter);
                        else
                            handlers.AddHandlerAtTheEnd(ht.handlerTwo);
                        dataGridView1.DataSource = handlers.GetHandlerTwo();
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Format error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
            }
            catch (ArgumentException ex)
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

        private void button3_Click(object sender, EventArgs e)
        {
            var id = (int)dataGridView1.SelectedRows[0].Cells[0].RowIndex;

            if (typeof(T2) == typeof(HandlerOne))
            {
                var ho = handlers.GetHandlerOne().ElementAt(id - 1);
                if (ho != null)
                {
                    handlers.RemoveHandlerByName(ho.Name);
                    dataGridView1.DataSource = handlers.GetHandlerOne();
                }
            }
            else if (typeof(T2) == typeof(HandlerTwo))
            {
                var ht = handlers.GetHandlerTwo().ElementAt(id - 1);
                if (ht != null)
                {
                    handlers.RemoveHandlerByName(ht.Name);
                    dataGridView1.DataSource = handlers.GetHandlerTwo();
                }
            }
        }
    }
}
