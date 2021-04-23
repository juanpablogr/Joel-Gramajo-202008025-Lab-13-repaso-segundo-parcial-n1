using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;

namespace Joel_Gramajo_202008025_Lab_13_repaso_segundo_parcial_n1
{
    public partial class About : Page
    {
        static List<Universidad> unis = new List<Universidad>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadList();

                DropDownList1.Items.Clear();
                for (int i = 0; i < unis.Count; i++)
                {
                    DropDownList1.Items.Add(unis[i].Nombre);
                }
            }
            RefreshGrid();
        }

        void LoadList()
        {
            try
            {
                string path = Server.MapPath("Universidades.json");
                StreamReader sr = File.OpenText(path);
                string json = sr.ReadToEnd();
                unis = JsonConvert.DeserializeObject<List<Universidad>>(json);
                sr.Close();
            }
            catch
            {

            }
        }

        void RefreshGrid()
        {
            if (DropDownList1.SelectedIndex != -1 && DropDownList2.SelectedIndex != -1)
            {
                if (DropDownList2.SelectedIndex == 0)
                {
                    GridView1.DataSource = unis[DropDownList1.SelectedIndex].Alumnos;
                }
                if (DropDownList2.SelectedIndex == 1)
                {
                    GridView1.DataSource = unis[DropDownList1.SelectedIndex].Profesores;
                }
                if (DropDownList2.SelectedIndex == 2)
                {
                    GridView1.DataSource = unis[DropDownList1.SelectedIndex].Administrativos;
                }

                GridView1.DataBind();
            }
        }

        void Alerta(string msg)
        {
            Response.Write("<script LANGUAGE='JavaScript'> alert('" + msg + "') </script>");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
        }

        protected void DropDownList2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}