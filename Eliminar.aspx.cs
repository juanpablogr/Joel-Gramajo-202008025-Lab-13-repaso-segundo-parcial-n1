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
    public partial class Eliminar : System.Web.UI.Page
    {
        static List<Universidad> unis = new List<Universidad>();

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadList();

            DropDownList1.Items.Clear();
            for (int i = 0; i < unis.Count; i++)
            {
                DropDownList1.Items.Add(unis[i].Nombre);
            }
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

        void SaveList()
        {
            string path = Server.MapPath("Universidades.json");
            string json = JsonConvert.SerializeObject(unis);

            StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Truncate, FileAccess.Write));
            sw.Write(json);
            sw.Close();
        }

        void Alerta(string msg)
        {
            Response.Write("<script LANGUAGE='JavaScript'> alert('" + msg + "') </script>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex != -1 && DropDownList2.SelectedIndex != -1)
            {
                int idx;

                switch (DropDownList2.SelectedIndex)
                {
                    case 0:
                        idx = unis[DropDownList1.SelectedIndex].Alumnos.FindIndex(a => a.Carne == TextBox1.Text);
                        if (idx != -1)
                        {
                            unis[DropDownList1.SelectedIndex].Alumnos.RemoveAt(idx);
                            TextBox1.Text = "";
                        }
                        else Alerta("ERROR: Persona no econtrada!");
                        break;

                    case 1:
                        idx = unis[DropDownList1.SelectedIndex].Profesores.FindIndex(a => a.Id_profesor == TextBox1.Text);
                        if (idx != -1)
                        {
                            unis[DropDownList1.SelectedIndex].Profesores.RemoveAt(idx);
                            TextBox1.Text = "";
                        }
                        else Alerta("ERROR: Persona no econtrada!");
                        break;

                    case 2:
                        idx = unis[DropDownList1.SelectedIndex].Administrativos.FindIndex(a => a.Numero_IGSS == TextBox1.Text);
                        if (idx != -1)
                        {
                            unis[DropDownList1.SelectedIndex].Administrativos.RemoveAt(idx);
                            TextBox1.Text = "";
                        }
                        else Alerta("ERROR: Persona no econtrada!");
                        break;
                }

                SaveList();
            }
            else Alerta("ERROR: Debe seleccionar una universidad y un grupo de personas.");
        }
    }
}