namespace Lista
{
    public partial class Lista3 : Form
    {
        private ListaJardin ListaJardin = new ListaJardin();

        public Lista3()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                String RegCivil = txtCivil.Text;
                String Nombre = txtName.Text;
                String Cond = boxCondicion.Text;
                String Estrato = boxEstrato.Text;
                DateTime fecNac = boxDate.Value;
                String Terapia = (siRadio.Checked) ? "Si" : "No";

                if (RegCivil == "" || Nombre == "" || Cond == "" || Estrato == "")
                    throw new Exception();

                //
                Estudiante newEstudiante = new Estudiante(
                        RegCivil,
                        Nombre,
                        Cond,
                        Estrato,
                        fecNac,
                        Terapia
                    );

                //
                lblError.Text = "";
                ListaJardin.Push(newEstudiante);
                gridEstudiantes.Rows.Add(newEstudiante._RegistroCivil,
                    newEstudiante._NombreCompleto,
                    newEstudiante._CondicionEspecial,
                    newEstudiante._Estrato,
                    newEstudiante._FecNacimiento,
                    newEstudiante._Terapia
                    );
                resetFields();
            }
            catch (Exception ex)
            {
                lblError.Text = "Revisa todos los campos.";
            }
        }

        public void resetFields()
        {
            txtCivil.Text = "";
            txtName.Text = "";
            boxCondicion.Text = "";
            boxEstrato.Text = "";
            siRadio.Checked = false;
            noRadio.Checked = false;
        }

        public void resetFieldDel()
        {
            txtCivildel.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String RegistroCivil = txtCivildel.Text;
                int indice = ListaJardin.Search(RegistroCivil);
                if (indice == -1)
                    throw new Exception();

                //
                errorLbl2.Text = "";
                gridEstudiantes.Rows.RemoveAt(indice);
                ListaJardin.Delete(indice);
                resetFieldDel();
            }
            catch (Exception ex)
            {
                errorLbl2.Text = "Error registro civil.";
            }
        }
    }

    public class Estudiante
    {
        public String _RegistroCivil;
        public String _NombreCompleto;
        public String _CondicionEspecial;
        public String _Estrato;
        public DateTime _FecNacimiento;
        public String _Terapia;

        public Estudiante(string rc, string name, string condicion, string estrato, DateTime fecNac,
            string terapy)
        {
            this._RegistroCivil = rc;
            this._NombreCompleto = name;
            this._CondicionEspecial = condicion;
            this._Estrato = estrato;
            this._FecNacimiento = fecNac;
            this._Terapia = terapy;
        }
    }

    public class ListaJardin
    {
        private List<Estudiante> list = new List<Estudiante>();

        public void Push(Estudiante estudiante)
        {
            list.Add(estudiante);
        }

        public void Delete(int index)
        {
            list.RemoveAt(index);
        }

        public int Search(String registroCivil)
        {
            int index = list.FindIndex(a => a._RegistroCivil == registroCivil);
            return index;
        }
    }
}