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
    public partial class FormCajero : Form
    {
        private string Apellido;
        private string Nombre;
        private string NumPin;
        private string NumTarjeta;
        private string archivoSaldo;
        private string cuenta;
        private string saldo;

        public FormCajero(string numTarjeta, string numPin, string nombre, string apellido)
        {
            this.NumTarjeta = numTarjeta;
            this.NumPin = numPin;
            this.Nombre = nombre;
            this.Apellido = apellido;
            InitializeComponent();
            this.lblNombre.Text = "Bienvenido " + nombre + " " + apellido;
            this.archivoSaldo = @"c:\cuentas\" + NumTarjeta + ".txt";
            this.cuenta = "";
            this.saldo = "";
            Saldo xsaldo = new Saldo(archivoSaldo);
            cuenta = xsaldo.getSaldo();
            saldo = xsaldo.getSaldo();
            Console.WriteLine("Saldo " + cuenta + " " + saldo);

        }

        private void FormCajero_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Efectivo efec = new Efectivo();
            if (efec.MuestraEfectivo() >= 300.00)
            {
                Retiro(300.00);
                efec.ActualizaEfectivo(300.00);
            }
            else
            {
                this.LblMensaje.Text = "Cajero no Tiene Efectivo para hacer la Transaccion";
                LblMensaje.ForeColor = Color.Red;
            }
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            Saldo xSaldo = new Saldo(archivoSaldo);
            lblSaldo.Text = "C$. " + xSaldo.getSaldo();
           
        }

        private void RetirarCincuenta_Click(object sender, EventArgs e)
        {
            this.LblMensaje.Text = " ";
            Efectivo efec = new Efectivo();
            if (efec.MuestraEfectivo() >= 50.00)
            {
                Retiro(50.00);
                efec.ActualizaEfectivo(50.00);

            }
            else
            {
                this.LblMensaje.Text = "Cajero no Tiene Efectivo para hacer la Transaccion";
                LblMensaje.ForeColor = Color.Red;
            }
        }
        private void Retiro(double cantidad)
        {
            Saldo xSaldo = new Saldo(archivoSaldo);
            double doubleSaldo = double.Parse(xSaldo.getSaldo());
            if (doubleSaldo >= cantidad)
            {
                xSaldo.ActualizaSaldo(cantidad);
                this.LblMensaje.Text = "Se han retirado Q " + cantidad.ToString();
                LblMensaje.ForeColor = Color.Blue;

            }
            else
            {
                this.LblMensaje.Text = "No tiene suficiente Saldo para hacer la Transaccion";
                LblMensaje.ForeColor = Color.Red;
            }
        }

        private void RetirarCien_Click(object sender, EventArgs e)
        {
            Efectivo efec = new Efectivo();
            if (efec.MuestraEfectivo() >= 100.00)
            {
                Retiro(100.00);
                efec.ActualizaEfectivo(100.00);
            }
            else
            {
                this.LblMensaje.Text = "Cajero no Tiene Efectivo para hacer la Transaccion";
                lblNombre.ForeColor = Color.Red;
            }
        }

        private void RetirarDoscientos_Click(object sender, EventArgs e)
        {
            Efectivo efec = new Efectivo();
            if (efec.MuestraEfectivo() >= 200.00)
            {
                Retiro(200.00);
                efec.ActualizaEfectivo(200.00);
            }
            else
            {
                this.LblMensaje.Text = "Cajero no Tiene Efectivo para hacer la Transaccion";
                LblMensaje.ForeColor = Color.Red;
            }
        }

        private void RetirarDoscientosCin_Click(object sender, EventArgs e)
        {
            Efectivo efec = new Efectivo();
            if (efec.MuestraEfectivo() >= 250.00)
            {
                Retiro(250.00);
                efec.ActualizaEfectivo(250.00);
            }
            else
            {
                this.LblMensaje.Text = "Cajero no Tiene Efectivo para hacer la Transaccion";
                LblMensaje.ForeColor = Color.Red;
            }
        }

        private void RetirarQuinientos_Click(object sender, EventArgs e)
        {
            Efectivo efec = new Efectivo();
            if (efec.MuestraEfectivo() >= 500.00)
            {
                Retiro(500.00);
                efec.ActualizaEfectivo(500.00);
            }
            else
            {
                this.LblMensaje.Text = "Cajero no Tiene Efectivo para hacer la Transaccion";
                LblMensaje.ForeColor = Color.Red;
            }
        }

        private void RetirarMil_Click(object sender, EventArgs e)
        {
            Efectivo efec = new Efectivo();
            if (efec.MuestraEfectivo() >= 1000.00)
            {
                Retiro(1000.00);
                efec.ActualizaEfectivo(1000.00);
            }
            else
            {
                this.LblMensaje.Text = "Cajero no Tiene Efectivo para hacer la Transaccion";
                LblMensaje.ForeColor = Color.Red;
            }
        }

        private void RetirarDosMil_Click(object sender, EventArgs e)
        {
            Efectivo efec = new Efectivo();
            if (efec.MuestraEfectivo() >= 2000.00)
            {
                Retiro(2000.00);
                efec.ActualizaEfectivo(2000.00);
            }
            else
            {
                this.LblMensaje.Text = "Cajero no Tiene Efectivo para hacer la Transaccion";
                LblMensaje.ForeColor = Color.Red;
            }
        }
    }
}
