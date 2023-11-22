using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Diagnostics;
using System.Media;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Pila
{
    public partial class Pila : Form
    {
        private Reserva reserva = new Reserva();
        private PilaBolos pilabolos = new PilaBolos();

        public Pila()
        {
            InitializeComponent();
        }

        private void sendform_Click(object sender, EventArgs e)
        {
            if (fullname.Text != "" && address.Text != "" && idnumber.Text != ""
            && numberplayers.Text != "" && numberbowling.Text != "" && (affiliatefalse.Checked
            || affiliatetrue.Checked))
            {
                dataReservas.Rows.Add(reserva.name, reserva.address,
                    Convert.ToString(reserva.idnum), Convert.ToString(reserva.numplayers),
                    Convert.ToString(reserva.numbowling), Convert.ToString(reserva.date),
                    Convert.ToString(reserva.affiliate), Convert.ToString(reserva.price));

                pilabolos.Push(reserva);
                reset();
            }

        }

        public void reset()
        {
            try
            {
                reserva = new Reserva();

                fullname.Text = "";
                address.Text = "";
                idnumber.ResetText();
                numberplayers.ResetText();
                numberbowling.ResetText();
                affiliatefalse.Checked = false;
                affiliatetrue.Checked = false;
                total.Text = "0";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void updatePrice()
        {
            this.reserva.price = 50000;
            this.reserva.aditionalPlayers();
            this.reserva.aditionalBowling();
            this.reserva.discount();
            total.Text = Convert.ToString(this.reserva.price);
        }

        private void fullname_TextChanged(object sender, EventArgs e)
        {
            this.reserva.name = fullname.Text;
            updatePrice();
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            this.reserva.address = address.Text;
            updatePrice();
        }

        private void idnumber_TextChanged(object sender, EventArgs e)
        {
            this.reserva.idnum = Convert.ToInt32(idnumber.Text);
            updatePrice();
        }

        private void numberplayers_ValueChanged(object sender, EventArgs e)
        {
            this.reserva.numplayers = Convert.ToInt32(numberplayers.Text);
            updatePrice();
        }

        private void numberbowling_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.reserva.numbowling = Convert.ToInt32(numberbowling.Text);
            updatePrice();
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            this.reserva.date = Convert.ToDateTime(date.Text);
            updatePrice();
        }

        private void affiliatetrue_CheckedChanged(object sender, EventArgs e)
        {
            this.reserva.affiliate = true;
            updatePrice();
        }

        private void affiliatefalse_CheckedChanged(object sender, EventArgs e)
        {
            this.reserva.affiliate = false;
            updatePrice();
        }

        private void totalbutton_Click(object sender, EventArgs e)
        {
            totalRec.Text = Convert.ToString(this.pilabolos.totalRecaudado);
        }

        private void removeregisters_Click(object sender, EventArgs e)
        {
            if(this.pilabolos.Size() > 0)
            {
                this.pilabolos.Pop();
                dataReservas.Rows.RemoveAt(this.pilabolos.Size());
            }
        }
    }

    public class Reserva
    {
        public string name { get; set; }
        public string address { get; set; }
        public int idnum { get; set; }
        public int numplayers { get; set; }
        public int numbowling { get; set; }
        public DateTime date { get; set; }
        public bool affiliate { get; set; }
        public int price = 50000;

        public Reserva()
        {
            this.name = "";
            this.address = "";
            this.idnum = 0;
            this.numplayers = 0;
            this.numbowling = 0;
            this.date = new DateTime();
            this.affiliate = false;
        }

        public void aditionalPlayers()
        {
            if (this.numplayers == 2)
                this.price = this.price + 1000;
            else if (this.numplayers == 3)
                this.price = this.price + 2000;
            else if (this.numplayers == 4)
                this.price = this.price + 3000;
            else if (this.numplayers == 5)
                this.price = this.price + 4000;
            else if (this.numplayers == 6)
                this.price = this.price + 5000;
        }

        public void aditionalBowling()
        {
            if (this.numbowling == 3)
                this.price = this.price + 5000;
            else if (this.numbowling == 4)
                this.price = this.price + 10000;
        }

        public void discount()
        {
            if (this.affiliate == true)
                this.price = Convert.ToInt32(this.price - this.price * 0.10);
        }


    }
    public class PilaBolos
    {
        private Stack<Reserva> stack;
        public decimal totalRecaudado;

        public PilaBolos()
        {
            this.stack = new Stack<Reserva>();
            this.totalRecaudado = 0;
        }

        public void Push(Reserva reserva)
        {
            this.stack.Push(reserva);
            this.totalRecaudado += reserva.price;
        }

        public void Pop()
        {
            this.totalRecaudado -= this.stack.Peek().price;
            this.stack.Pop();
        }

        public int Size()
        {
            return this.stack.Count;
        }

    }
}