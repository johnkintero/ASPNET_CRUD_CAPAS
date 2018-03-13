using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussines_Layer;
using Data_Layer;



public partial class Paginas_index : System.Web.UI.Page
{

    BussinesPrueba metodosnegocio = new BussinesPrueba();
    EntidadBDprueba entidadprueba = new EntidadBDprueba();
    tbl_prueba entidadtblprueba = new tbl_prueba();
    private void save()
    {
        entidadprueba.NID = Convert.ToInt32(txtnid.Text);
        entidadprueba.Nombre = txtnombre.Text;
        entidadprueba.Fecha = Calendar1.SelectedDate.Date;
        entidadprueba.Activo = true;
        metodosnegocio.save(entidadprueba);
    }

    private void saveSP()
    {
        entidadtblprueba.NID = Convert.ToInt32(txtnid.Text);
        entidadtblprueba.Nombre = txtnombre.Text;
        entidadtblprueba.Fecha = Calendar1.SelectedDate.Date;
        entidadtblprueba.activo = true;
        metodosnegocio.saveSP(entidadtblprueba);
    }

    private void DeleteSP(int iddelete)
    {
        entidadtblprueba.id = iddelete;
        metodosnegocio.DeleteSP(entidadtblprueba.id);
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            GridView1.DataSource = metodosnegocio.mostrardatos();
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Label1.Text = ex.ToString();
        }
    
    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            save();
        }
        catch (Exception ex)
        {
            Label1.Text = ex.ToString();
        }

    }

    protected void BtnSaveSP_Click(object sender, EventArgs e)
    {
        try
        {
            saveSP();
        }
        catch (Exception ex)
        {
            Label1.Text = ex.ToString();
        }
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName=="Delete")
        {
            try
            {
                int index = int.Parse(e.CommandArgument.ToString());
                DeleteSP(Convert.ToInt32(GridView1.DataKeys[index].Value.ToString()));
            }
            catch(Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            
        }
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            GridView1.DataSource = metodosnegocio.mostrardatos();
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Label1.Text = ex.ToString();
        }
    }
}