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
    public partial class Contact : Page
    {
        static List<Universidad> unis = new List<Universidad>();
        static int idx = -1;

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
        }

        void Alerta(string msg)
        {
            Response.Write("<script LANGUAGE='JavaScript'> alert('" + msg + "') </script>");
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            unis[DropDownList1.SelectedIndex].Alumnos[idx].Nombre = TextBox2.Text;
            unis[DropDownList1.SelectedIndex].Alumnos[idx].Apellido = TextBox3.Text;
            unis[DropDownList1.SelectedIndex].Alumnos[idx].Direccion = TextBox4.Text;
            unis[DropDownList1.SelectedIndex].Alumnos[idx].Fecha_de_nacimiento = DateTime.Parse(TextBox5.Text);
            unis[DropDownList1.SelectedIndex].Alumnos[idx].Carne = TextBox6.Text;

            TextBox2.Text = "";
            TextBox3.Text = "";
            Label1.Text = "----";
            TextBox4.Text = "";
            TextBox6.Text = "";

            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            TextBox5.Enabled = false;
            TextBox6.Enabled = false;

            Button2.Enabled = false;

            DropDownList1.Enabled = true;
            TextBox1.Enabled = true;
            Button1.Enabled = true;

            SaveList();
            TextBox1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex != -1)
            {
                if (TextBox1.Text != "")
                {
                    idx = unis[DropDownList1.SelectedIndex].Alumnos.FindIndex(a => a.Carne == TextBox1.Text);

                    if (idx != -1)
                    {
                        DropDownList1.Enabled = false;
                        TextBox1.Enabled = false;
                        Button1.Enabled = false;

                        TextBox2.Text = unis[DropDownList1.SelectedIndex].Alumnos[idx].Nombre;
                        TextBox3.Text = unis[DropDownList1.SelectedIndex].Alumnos[idx].Apellido;
                        TextBox4.Text = unis[DropDownList1.SelectedIndex].Alumnos[idx].Direccion;
                        TextBox6.Text = unis[DropDownList1.SelectedIndex].Alumnos[idx].Carne;
                        Label1.Text = unis[DropDownList1.SelectedIndex].Alumnos[idx].Fecha_de_nacimiento.ToString("dd/MM/yyyy");


                        TextBox2.Enabled = true;
                        TextBox3.Enabled = true;
                        TextBox4.Enabled = true;
                        TextBox5.Enabled = true;
                        TextBox6.Enabled = true;

                        Button2.Enabled = true;
                    }
                    else Alerta("ERROR: El alumno no existe!");
                }
                else Alerta("ERROR: Datos inválidos!");
            }
            else Alerta("ERROR: No ha seleccionado una universidad!");
        }
    }
}