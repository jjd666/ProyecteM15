using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class repartidorDTO
    {
        public int idRepartidor { get; set; }
        public string Nombre { get; set; }
        public string DNIrep { get; set; }
        public string Zona { get; set; }

        public Boolean activo { get; set; }

        public repartidorDTO(repartidor r) {
            this.idRepartidor = r.idRepartidor;
            this.Nombre = r.Nombre;
            this.DNIrep = r.DNIrep;
            this.Zona = r.Zona;
            this.activo = r.Activo;


        }


        public repartidorDTO(int idRepartidor,string Nombre,string Zona,string DNIrep, Boolean activo)
        {
            this.idRepartidor = idRepartidor;
            this.Nombre = Nombre;
            this.DNIrep = DNIrep;
            this.Zona = Zona;
            this.activo = activo;


        }
        public static repartidorDTO clientedtoparalinia(DataGridViewCellCollection row)
        {


            return new repartidorDTO((int)row["idRepartidor"].Value, (string)row["Nombre"].Value,  (string)row["DNIrep"].Value, (string)row["Zona"].Value,(Boolean)row[" activo"].Value);

        }
    }
}

    

