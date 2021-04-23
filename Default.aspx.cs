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
    public partial class _Default : Page
    {
        static List<Universidad> unis = new List<Universidad>();
        static int op;

        protected void Page_Load(object sender, EventArgs e)
        {
            MaintainScrollPositionOnPostBack = true;
            LoadList();
            if (!IsPostBack)
            {
                MostrarControles(0);
            }
        }

        void LoadList()
        {
            try
            {
                string path = Server.MapPath("Universidades.json");
                StreamReader sr = File.OpenText(path);
                string json = sr.ReadToEnd();
                if (json.Length != 0) {
                    unis = JsonConvert.DeserializeObject<List<Universidad>>(json);
                }
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

        void MostrarControles(int idx)
        {
            bool[] est = { false, false, false };

            if (idx != -1) est[idx] = true;
            Button4.Visible = idx != -1;

            Label6.Visible = est[0]; TextBox6.Visible = est[0]; TextBox6.Text = "";
            Label7.Visible = est[1]; TextBox7.Visible = est[1]; TextBox7.Text = "";
            Label8.Visible = est[1]; TextBox8.Visible = est[1]; TextBox8.Text = "";
            Label9.Visible = est[2]; TextBox9.Visible = est[2]; TextBox9.Text = "";
            Label10.Visible = est[2]; TextBox10.Visible = est[2]; TextBox10.Text = "";
            Label11.Visible = est[2]; TextBox11.Visible = est[2]; TextBox11.Text = "";
            Label12.Visible = est[2]; TextBox12.Visible = est[2]; TextBox12.Text = "";

            Button1.CssClass = est[0]? "btn btn-success" : "btn btn-primary";
            Button2.CssClass = est[1]? "btn btn-success" : "btn btn-primary";
            Button3.CssClass = est[2]? "btn btn-success" : "btn btn-primary";
        }

        void Alerta(string msg)
        {
            Response.Write("<script LANGUAGE='JavaScript'> alert('" + msg + "') </script>");
        }

        void BorrarDatosGenericos()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MostrarControles(0);
            op = 0;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MostrarControles(1);
            op = 1;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MostrarControles(2);
            op = 2;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "")
            {
                int uidx = unis.FindIndex(u => u.Nombre == TextBox1.Text);

                if (op == 0) // para ingresar alumnos
                {
                    if (TextBox6.Text != "")
                    {
                        int pos = (uidx == -1) ? unis.Count : uidx;
                        if (uidx == -1) unis.Add(new Universidad(TextBox1.Text));

                        unis[pos].Alumnos.Add(new Alumno(TextBox2.Text, TextBox3.Text, TextBox4.Text, DateTime.Parse(TextBox5.Text), TextBox6.Text));
                        MostrarControles(-1);
                        BorrarDatosGenericos();
                    }
                    else Alerta("ERROR: Datos incompletos o inválidos del alumno!");
                }

                if (op == 1) // para ingresar profesores
                {
                    if (TextBox7.Text != "" && TextBox8.Text != "")
                    {
                        int pos = (uidx == -1) ? unis.Count : uidx;
                        if (uidx == -1) unis.Add(new Universidad(TextBox1.Text));

                        unis[pos].Profesores.Add(new Profesor(TextBox2.Text, TextBox3.Text, TextBox4.Text, DateTime.Parse(TextBox5.Text), TextBox7.Text, TextBox8.Text));
                        MostrarControles(-1);
                        BorrarDatosGenericos();
                    }
                    else Alerta("ERROR: Datos incompletos o inválidos del profesor!");
                }

                if (op == 2) // para ingresar administrativos
                {
                    if (TextBox9.Text != "" && TextBox10.Text != "" && TextBox11.Text != "" && TextBox12.Text != "")
                    {
                        int pos = (uidx == -1) ? unis.Count : uidx;
                        if (uidx == -1) unis.Add(new Universidad(TextBox1.Text));

                        unis[pos].Administrativos.Add(new Administrativo(TextBox2.Text, TextBox3.Text, TextBox4.Text, DateTime.Parse(TextBox5.Text), TextBox9.Text, TextBox10.Text, DateTime.Parse(TextBox11.Text), DateTime.Parse(TextBox12.Text)));
                        MostrarControles(-1);
                        BorrarDatosGenericos();
                    }
                    else Alerta("ERROR: Datos incompletos o inválidos del administrativo!");
                }

                SaveList();
            }
            else Alerta("ERROR: Datos incompletos o inválidos!");
        }
    }
}