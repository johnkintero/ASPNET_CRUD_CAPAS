using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class MetodosPrueba
    {
        PruebaEntities modeldbentidades = new PruebaEntities();
        public string Save(tbl_prueba dat_tblPrueba)
        {
            try
            {
                modeldbentidades.tbl_prueba.Add(dat_tblPrueba);
                modeldbentidades.SaveChanges();
                return "Saved";
             
            }
            catch (Exception ex)
            {
                throw ex;
            }
         }
        //Guarda utilizando un Storedprocedure de sql
        public string SaveSP(tbl_prueba dat_tblprueba)
        {
            try
            {
                modeldbentidades.SP_Ins_tblprueba(dat_tblprueba.NID, dat_tblprueba.Nombre, dat_tblprueba.Fecha, dat_tblprueba.activo);
                return "Saved";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tbl_prueba> Mostrardatos()
        {
            try
            {
                var query = (from e in modeldbentidades.tbl_prueba select e);
                return query.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        //elimina utilizando un Storedprocedure de sql
        public string DeleteSP(int iddelete)
        {
            try
            {
                modeldbentidades.SP_Del_tblprueba(iddelete);
                return "ELIMINADO";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
