//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Layer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_carros
    {
        public int id_prueba { get; set; }
        public string carro { get; set; }
        public string color { get; set; }
        public int id { get; set; }
    
        public virtual tbl_prueba tbl_prueba { get; set; }
    }
}