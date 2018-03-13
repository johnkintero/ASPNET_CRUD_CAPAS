using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace Bussines_Layer
{
    public class BussinesPrueba
    {
        MetodosPrueba metodosDb = new MetodosPrueba();
        //almacenando directo con EF
        public string save(EntidadBDprueba dat)
        {
            tbl_prueba tbl = new tbl_prueba();
            tbl.NID = dat.NID;
            tbl.Nombre = dat.Nombre;
            tbl.Fecha = dat.Fecha;
            tbl.activo = dat.Activo;
            return metodosDb.Save(tbl);
        }
        // LLama al proceso que almacena con un SP usando la clase entidad que 
        // genero el entity automaticamente
        public string saveSP(tbl_prueba dat)
        {
            try
            {
                /*tbl_prueba tbl = new tbl_prueba();
                tbl.NID = dat.NID;
                tbl.Nombre = dat.Nombre;
                tbl.Fecha = dat.Fecha;
                tbl.activo = dat.Activo;*/
                return metodosDb.SaveSP(dat);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<tbl_prueba> mostrardatos()
        {
            return metodosDb.Mostrardatos();
        }

        // LLama al proceso que elimina con un SP usando la clase entidad que 
        // genero el entity automaticamente
        public string DeleteSP(int iddelete)
        {
            try
            {
                return metodosDb.DeleteSP(iddelete);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
