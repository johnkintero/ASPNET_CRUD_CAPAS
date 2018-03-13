﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PruebaEntities : DbContext
    {
        public PruebaEntities()
            : base("name=PruebaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_carros> tbl_carros { get; set; }
        public virtual DbSet<tbl_prueba> tbl_prueba { get; set; }
        public virtual DbSet<Vw_tblpruebaXtblcarros> Vw_tblpruebaXtblcarros { get; set; }
    
        public virtual ObjectResult<Sel_tblprueba_all_Result> Sel_tblprueba_all()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sel_tblprueba_all_Result>("Sel_tblprueba_all");
        }
    
        public virtual int SP_Ins_tblprueba(Nullable<decimal> nid, string nombre, Nullable<System.DateTime> fecha, Nullable<bool> activo)
        {
            var nidParameter = nid.HasValue ?
                new ObjectParameter("nid", nid) :
                new ObjectParameter("nid", typeof(decimal));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var activoParameter = activo.HasValue ?
                new ObjectParameter("activo", activo) :
                new ObjectParameter("activo", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Ins_tblprueba", nidParameter, nombreParameter, fechaParameter, activoParameter);
        }
    
        public virtual ObjectResult<SP_Sel_tblprueba_nid_Result> SP_Sel_tblprueba_nid(Nullable<decimal> nid)
        {
            var nidParameter = nid.HasValue ?
                new ObjectParameter("nid", nid) :
                new ObjectParameter("nid", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Sel_tblprueba_nid_Result>("SP_Sel_tblprueba_nid", nidParameter);
        }
    
        public virtual ObjectResult<SP_Sel_TBlpruebasXtblcarros_Result> SP_Sel_TBlpruebasXtblcarros(Nullable<decimal> nid)
        {
            var nidParameter = nid.HasValue ?
                new ObjectParameter("nid", nid) :
                new ObjectParameter("nid", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Sel_TBlpruebasXtblcarros_Result>("SP_Sel_TBlpruebasXtblcarros", nidParameter);
        }
    
        public virtual int SP_Del_tblprueba(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Del_tblprueba", idParameter);
        }
    }
}
