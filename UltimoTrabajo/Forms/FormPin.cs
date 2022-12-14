using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimoTrabajo.Clases;

namespace UltimoTrabajo.Forms
{
    public partial class FormPin : Form
    {
        List<Usuario> listUsuarios = new List<Usuario>();
        private String NumTarjeta;
        private String NumPin;
        private String Nombre;
        private String Apellido;
        public FormPin(string numTarjeta, string numPin, string nombre, string apellido)
        {
            this.NumTarjeta = numTarjeta;
            this.NumPin = numPin;
            this.Nombre = nombre;
            this.Apellido = apellido;
            listUsuarios.Add(new Usuario("Marvin", "Moran", "123456", "7830"));
            listUsuarios.Add(new Usuario("Efrain", "Canastuj", "333333", "2222"));
            listUsuarios.Add(new Usuario("William", "Yuman", "444444", "0000"));
            InitializeComponent();
        }

 

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Boolean login = false;
            if (this.txtContraseña.Text.Length <= 0)
            {
                this.LblMensajePin.Text = "Ingrese No. de Pin";
                login = false;
            }
            else
            {

                foreach (Usuario result in listUsuarios)
                {
                    if (result.getPin().Equals(this.txtContraseña.Text.Trim()))
                    {
                        FormCajero formCaje = new FormCajero(result.getNumTarjeta(), result.getPin(), result.getNombre(), result.getApellido());
                        formCaje.ShowDialog();
                        this.Close();
                    }
                }
                if (login == false)
                {
                    this.LblMensajePin.Text = "No Existe ese Pin";
                }
            }

        }

        private void FormPin_Load(object sender, EventArgs e)
        {

        }
    }
}
