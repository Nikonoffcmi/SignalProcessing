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

        public HandlerOneForm(HandlerOne handlerOne,List<string> names) : this(names)
        {
            this.handlerOne = handlerOne;
            textBox1.Text = handlerOne.Name;
            textBox2.Text = handlerOne.MinInterf.ToString();
            textBox3.Text = handlerOne.MaxInterf.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var min = int.Parse(textBox2.Text);
            var max = int.Parse(textBox3.Text);
            nameafter = comboBox1.Text;

            handlerOne = new HandlerOne(name, min, max);
            Close();

        }
    }
}
