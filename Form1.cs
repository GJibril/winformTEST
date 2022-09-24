using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformTEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TodoListComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            var formPopup = new Form();
            formPopup.Show(this); // if you need non-modal window
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(textBox1.Text);
        }
    }
}
