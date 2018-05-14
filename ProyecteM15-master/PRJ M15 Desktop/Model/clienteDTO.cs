using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{

    public class clienteDTO
    {

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }


        public clienteDTO(string dni, string nombre, string telefono, string direccion)
        {
            this.DNI = dni;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Direccion = direccion;
        }
        public clienteDTO(cliente c)
        {
            this.DNI = c.DNI;
            this.Nombre = c.Nombre;
            this.Telefono = c.Telefono;
            this.Direccion = c.Direccion;
        }

        public static clienteDTO clientedtoparalinia(DataGridViewCellCollection row) {


            return new clienteDTO((string)row["DNI"].Value,(string)row["Nombre"].Value, (string)row["Telefono"].Value, (string)row["Direccion"].Value);

        } } }
