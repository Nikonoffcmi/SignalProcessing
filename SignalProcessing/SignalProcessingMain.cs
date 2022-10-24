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

namespace SignalProcessing
{
    public partial class SignalProcessingMain : Form
    {

        HandlerComposite handlers;

        public SignalProcessingMain()
        {
            InitializeComponent();
            handlers = new HandlerComposite();
        }

        private void AddHandlerOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ho = new HandlerOneForm(handlers.GetNames());
            if (ho.ShowDialog() == DialogResult.OK)
            { 
                handlers.AddHandlerAtTheEnd(ho.handlerOne);
                //toolStripComboBox1.Items.Add(ho.handlerOne.Name);
            }
        }

        private void AddHandlerTwoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ht = new HandlerTwoForm(handlers.GetNames());
            if (ht.ShowDialog() == DialogResult.OK)
            {
                handlers.AddHandlerAtTheEnd(ht.handlerTwo);
                //toolStripComboBox1.Items.Add(ht.handlerTwo.Name);
            }
        }
    }
}
