using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimoTrabajo.Clases
{
    public class Usuario
    {
        private String nombre;
        private String apellido;
        private String numTarjeta;
        private String pin;

        public Usuario(String Nombre, String Apellido, String NumTarjeta, String Pin)
        {
            this.nombre = Nombre;
            this.apellido = Apellido;
            this.numTarjeta = NumTarjeta;
            this.pin = Pin;

        }

        public void setNombre(String Nombre)
        {
            this.nombre = Nombre;
        }
        public String getNombre()
        {
            return this.nombre;
        }

        public void setApellido(String Apellido)
        {
            this.apellido = Apellido;
        }
        public String getApellido()
        {
            return this.apellido;
        }

        public void setNumTarjeta(String NumTarjeta)
        {
            this.numTarjeta = NumTarjeta;
        }
        public String getNumTarjeta()
        {
            return this.numTarjeta;
        }

        public void setPin(String Pin)
        {
            this.pin = Pin;
        }
        public String getPin()
        {
            return this.pin;
        }

    }
}
