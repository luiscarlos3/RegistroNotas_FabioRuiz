using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RegistroNotas
{
    public partial class frm_Listar_Consultas : Form
    {
        static string ruta = @"..\..\Data\Notas.xml";
        public frm_Listar_Consultas()
        {
            InitializeComponent();
        }

        private void frm_Listar_Consultas_Load(object sender, EventArgs e)
        {
            cargarGrillaConsultas();
        }

        public void cargarGrillaConsultas()
        {
            //Creamos un documento y lo cargamos con los datos del XML.
            XmlDocument documento = new XmlDocument();
            documento.Load(ruta);

            //Obtenemos una colección con todos los notas consultadas.
            XmlNodeList listaNotas = documento.SelectNodes("notas/nota");

            //Creamos nodo Nota.
            XmlNode Nota;

            //Limpiamos datagridview
            dgv.Rows.Clear();
            //Recorremos toda la lista de notas consultadas.
            for (int i = 0; i < listaNotas.Count; i++)
            {
                //Obtenemos cada nota.
                Nota = listaNotas.Item(i);

                //Obtenemos valores para cada fila             
                string fec = Nota.SelectSingleNode("fecha_consulta").InnerText;
                string hora = Nota.SelectSingleNode("hora_consulta").InnerText;
                string cod = Nota.SelectSingleNode("codEstudiante").InnerText;
                string nom = Nota.SelectSingleNode("nombre").InnerText;
                string curso = Nota.SelectSingleNode("nombre_curso").InnerText;
                string n1 = Nota.SelectSingleNode("calificacion1").InnerText;
                string n2 = Nota.SelectSingleNode("calificacion2").InnerText;
                string nf = Nota.SelectSingleNode("calificacionDef").InnerText;
                string result = Nota.SelectSingleNode("resultado").InnerText;

                //Insertamos nueva fila en datagridview
                dgv.Rows.Add(fec, hora, cod, nom, curso, n1, n2, nf, result);
                dgv.Update();

            }
        }

      
    }
}
