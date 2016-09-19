using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Madhvi
{
    public partial class Gridview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
            {
            
                 if (!this.IsPostBack)
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Id"), new DataColumn("Name"), new DataColumn("Country") });
                        dt.Rows.Add(1, "John Hammond", "United States");
                        dt.Rows.Add(2, "Mudassar Khan", "India");
                        dt.Rows.Add(3, "Suzanne Mathews", "France");
                        dt.Rows.Add(4, "Robert Schidner", "Russia");
                        ViewState["dt"] = dt;
                        this.BindGrid();
                    }
            }
 
            protected void BindGrid()
            {
                 GridView1.DataSource = ViewState["dt"] as DataTable;
                 GridView1.DataBind();
            }

            protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
            {
        
            }

            protected void OnRowEditing(object sender, GridViewEditEventArgs e)
            {
             GridView1.EditIndex = e.NewEditIndex;
             this.BindGrid();
            }
            protected void OnUpdate(object sender, EventArgs e)
            {
                GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
                string name = (row.Cells[0].Controls[0] as TextBox).Text;
                string country = (row.Cells[1].Controls[0] as TextBox).Text;
                DataTable dt = ViewState["dt"] as DataTable;
                dt.Rows[row.RowIndex]["Name"] = name;
                dt.Rows[row.RowIndex]["Country"] = country;
                ViewState["dt"] = dt;
                GridView1.EditIndex = -1;
                this.BindGrid();
            }
 
            protected void OnCancel(object sender, EventArgs e)
            {
                GridView1.EditIndex = -1;
                this.BindGrid();
            }
        }
    }

