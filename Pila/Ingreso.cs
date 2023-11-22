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
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPwd.Text != "123")
            {
                lblError.Text = "Clave Erronea.";
            }
            else
            {
                lblError.Text = "";
                var m = new Menu();
                m.Show();
            }
        }
    }
}
