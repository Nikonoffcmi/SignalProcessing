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
        public HandlerTwoForm(List<string> names)
        {
            InitializeComponent();
            foreach (var name in names)
                comboBox1.Items.Add(name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var name = textBox4.Text;
            var average = int.Parse(textBox5.Text);

            handlerTwo = new HandlerTwo(name, average);
            //var nameafter = textBox6.Text;
            //if (nameafter != "")
            //    handlerComposite.AddHandlerByName(new HandlerTwo(name, average), nameafter);
            //else
            //    handlerComposite.AddHandlerAtTheEnd(new HandlerTwo(name, average));
            Close();
        }
    }
}
