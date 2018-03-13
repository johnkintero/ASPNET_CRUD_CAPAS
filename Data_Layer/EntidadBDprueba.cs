using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class EntidadBDprueba
    {
        public int id { get; set; }
        public decimal? NID { get; set; }
        public string Nombre { get; set; }
        public DateTime? Fecha { get; set; }
        public bool? Activo { get; set; }
        public DateTime Registro { get; set; }
    }
}
