namespace Cola
{
    public partial class Cola2 : Form
    {
        private ColaEPS ColaEPS = new ColaEPS();

        public Cola2()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                String Documento = txtID.Text;
                String Nombre = nameBox.Text;
                int Edad = Convert.ToInt32(ageBox.Value);
                String TipoConsulta = appnmntBox.Text;
                DateTime Fecha = date.Value;

                if (Documento == "" || Nombre == "" || Edad == 0 || TipoConsulta == "")
                    throw new Exception();

                lblError.Text = "";
                //
                Paciente nuevoPaciente = new Paciente(
                    Documento,
                    Nombre,
                    Edad,
                    TipoConsulta,
                    Fecha
                    );

                //
                ColaEPS.Enqueue(nuevoPaciente);
                registersBox.Rows.Add(nuevoPaciente._Documento, nuevoPaciente._NombreCompleto,
                    nuevoPaciente._Edad, nuevoPaciente._TipoConsulta, nuevoPaciente._Fecha);

                //
                resetFields();
            }
            catch (Exception ex)
            {
                lblError.Text = "Revisa todos los campos.";
            }
        }

        private void resetFields()
        {
            txtID.Text = "";
            nameBox.Text = "";
            ageBox.Value = 1;
            appnmntBox.Text = " ";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ColaEPS.Dequeue();
            registersBox.Rows.RemoveAt( 0 );
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            txtCount.Text = Convert.ToString( ColaEPS.Count() );
        }
    }

    public class Paciente
    {
        public String _Documento { get; set; }
        public String _NombreCompleto { get; set; }
        public int _Edad { get; set; }
        public String _TipoConsulta { get; set; }
        public DateTime _Fecha { get; set; }

        public Paciente(String doc, string name, int age, string tipo, DateTime date)
        {
            this._Documento = doc;
            this._NombreCompleto = name;
            this._Edad = age;
            this._TipoConsulta = tipo;
            this._Fecha = date;
        }

    }

    public class ColaEPS
    {
        private Queue<Paciente> queue = new Queue<Paciente>();

        public void Enqueue(Paciente paciente)
        {
            queue.Enqueue(paciente);
        }

        public Paciente Dequeue()
        {
            return queue.Dequeue();
        }

        public int Count()
        {
            return queue.Count;
        }

    }
}