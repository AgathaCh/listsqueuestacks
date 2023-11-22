using Cola;
using Lista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pila
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new Pila();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var m = new Cola2();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var m = new Lista3();
            m.Show();
        }
    }
}
