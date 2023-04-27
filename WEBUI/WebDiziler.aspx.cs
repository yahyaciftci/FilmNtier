using BLL.Repositories;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBUI
{
    public partial class WebDiziler : System.Web.UI.Page
    {
        SeriesRepository fr = new SeriesRepository();
        UserRepository ur = new UserRepository();
        UsersDTO us = new UsersDTO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            getirDizi();
            //LinkButton btn = DataList1.ItemTemplate as LinkButton;
            //string kullanici = ur.GetAll().Select(c => c.UserName).ToString();
            //if (kullanici=="dd")
            //{
                
            //    btn.Visible = true;
            //}
            //else
            //{
            //    btn.Visible = false;
            //}
        }

        private void getirDizi()
        {
            DataList1.DataSource = fr.GetAll();
            DataList1.DataBind();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        { 
            string kullanici = us.UserName;
            switch (e.CommandName)
            {
                case "Duzenle":
                    
                    if (kullanici=="dd")
                    {
                        DataList1.EditItemIndex = e.Item.ItemIndex;
                        getirDizi();
                    }
                    else
                    {

                    }
                    break;
                case "google":
                    Response.Redirect("https://www.google.com/search?q=" + e.CommandArgument);
                    getirDizi();
                    break;
                default:
                    break;
            }
           
        }
    }
}