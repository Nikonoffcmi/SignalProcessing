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
            if (typeof(T2) == typeof(HandlerOne))
            {
                var ho = new HandlerOneForm(handlers.GetNames());
                if (ho.ShowDialog() == DialogResult.OK)
                {
                    if (ho.nameafter != "")
                        handlers.AddHandlerByName(ho.handlerOne, ho.nameafter);
                    else
                        handlers.AddHandlerAtTheEnd(ho.handlerOne);
                    dataGridView1.DataSource = handlers.GethandlerOne();
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
                    dataGridView1.DataSource = handlers.GethandlerTwo();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            if (typeof(T2) == typeof(HandlerOne))
            {
                var ho = handlers.GethandlerOne().ElementAt(id - 1);
                if (ho != null)
                {
                    var hoForm = new HandlerOneForm(ho, handlers.GetNames());
                    if (hoForm.ShowDialog() == DialogResult.OK)
                    {
                        ho = hoForm.handlerOne;
                        if (hoForm.nameafter != "")
                            handlers.AddHandlerByName(ho.handlerOne, ho.nameafter);
                        else
                            handlers.AddHandlerAtTheEnd(ho.handlerOne);
                        dataGridView1.DataSource = handlers.GethandlerOne();

                    }
                }
            }
            else if (typeof(T2) == typeof(HandlerTwo))
            {
                var seller = set.Find(id) as Seller;
                if (seller != null)
                {
                    var form = new SellerForm(seller);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        seller = form.Seller;
                        db.SaveChanges();
                        dataGridView.Update();
                    }
                }
            }
        }
    }
}
