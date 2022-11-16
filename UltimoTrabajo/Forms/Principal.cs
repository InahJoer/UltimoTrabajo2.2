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
    public partial class Principal : Form
    {
        List<Usuario> listUsuarios = new List<Usuario>();
        public Principal()
        {
            InitializeComponent();

            listUsuarios.Add(new Usuario("Marvin", "Moran", "123456", "7830"));
            listUsuarios.Add(new Usuario("Efrain", "Canastuj", "333333", "2222"));
            listUsuarios.Add(new Usuario("William", "Yuman", "444444", "0000"));

        }
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Boolean login = false;
            if (this.txtTarjeta.Text.Length <= 0)
            {
                this.LblMensaje.Text = "Ingrese No. de Tarjeta";
                login = false;
            }
            else
            {

                foreach (Usuario result in listUsuarios)
                {
                    if (result.getNumTarjeta().Equals(this.txtTarjeta.Text.Trim()))
                    {
                        FormPin formPin = new FormPin(result.getNumTarjeta(), result.getPin(), result.getNombre(), result.getApellido());
                        formPin.ShowDialog();
                        this.Close();
                    }
                }
                if (login == false)
                {
                    this.LblMensaje.Text = "No tarjeta No Existe";
                }
            }

        }
    }
}
