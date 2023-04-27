using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBUI
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        FilmRepository fr = new FilmRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            getirFilm();

        }

        private void getirFilm()
        {
            DataList1.DataSource = fr.GetAll();
            DataList1.DataBind();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "google":
                    Response.Redirect("https://www.google.com/search?q=" + e.CommandArgument);
                    getirFilm();
                    break;
                default:
                    break;
            }
        }

        protected void DataList2_ItemCommand(object source, DataListCommandEventArgs e)
        {
        

        }
    }

    
    
}