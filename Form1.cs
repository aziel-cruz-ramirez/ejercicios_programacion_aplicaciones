using System;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
            this.label1.UseWaitCursor = false;
            this.label2.UseWaitCursor = false;
            this.label3.UseWaitCursor = false;
            this.button2.UseWaitCursor = false;
            this.button3.UseWaitCursor = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "si";
            label2.Text = "si";
            label3.Text = "si";
        }

  
    
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "NO";
            button2.Text = "NO";
            button3.Text = "NO";
        }

        private void button3_Click(object sender, EventArgs e)

        {
            button1.Text = "A";
            button2.Text = "B";
            button3.Text = "C";

            label1.Text = "Hola";
            label2.Text = "Hola";
            label3.Text = "Hola";
        }
    }
}
