﻿using Laba5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

        private void HandlerOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CatalogHandlerOne = new Catalog<List<HandlerOne>, HandlerOne>(handlers.GethandlerOne(), handlers);
            CatalogHandlerOne.Show();
            this.handlers = CatalogHandlerOne.handlers;
        }

        private void HandlerTwoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CatalogHandlerTwo = new Catalog<List<HandlerTwo>, HandlerTwo>(handlers.GethandlerTwo(), handlers);
            CatalogHandlerTwo.Show();
            this.handlers = CatalogHandlerTwo.handlers;
        }
    }
}
