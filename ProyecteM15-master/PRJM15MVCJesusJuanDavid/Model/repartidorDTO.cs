using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class repartidorDTO
    {
        public int idRepartidor { get; set; }
        public string Nombre { get; set; }
        public string DNIrep { get; set; }
        public string Zona { get; set; }

        public repartidorDTO(repartidor r) {
            this.idRepartidor = r.idRepartidor;
            this.Nombre = r.Nombre;
            this.DNIrep = r.DNIrep;
            this.Zona = r.Zona;


        }

        //public repartidorDTO(int idRepartidor)
        //{
        //    this.idRepartidor = r.idRepartidor;
        //    this.Nombre = r.Nombre;
        //    this.DNIrep = r.DNIrep;
        //    this.Zona = r.Zona;


        //}

    }
}
