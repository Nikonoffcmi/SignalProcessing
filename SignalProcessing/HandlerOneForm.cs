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
        public HandlerOne handlerOne;
        public HandlerOneForm(List<string> names)
        {
            InitializeComponent();
            foreach (var name in names)
                comboBox1.Items.Add(name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var min = int.Parse(textBox2.Text);
            var max = int.Parse(textBox3.Text);
            //var nameafter = textBox4.Text;
            handlerOne = new HandlerOne(name, min, max);
            //if (nameafter != "")
            //    handlerComposite.AddHandlerByName(new HandlerOne(name, min, max), nameafter);
            //else
            //    handlerComposite.AddHandlerAtTheEnd(new HandlerOne(name, min, max));
            Close();

        }
    }
}
