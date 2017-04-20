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
    public partial class frm_Add_Estudiante : Form
    {
        XmlDocument documento;
        static string ruta = @"..\..\Data\Estudiantes.xml";
        public frm_Add_Estudiante()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Validamos campos llenos
            if (txt_Code.Text == "" || txt_Names.Text == "" || txt_LastNames.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Registro de Notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_Code.ReadOnly)
            {
                ModificarDatosXml(txt_Code.Text, txt_Names.Text, txt_LastNames.Text);
            }
            else
            {
                InsertarXml();
                Clear();
            }
            MessageBox.Show("Datos guardados", "Registro de Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ObtenerEstudiante(string idEstudiante)
        {
            //Creamos un documento y lo cargamos con los datos del XML.
            XmlDocument documento = new XmlDocument();
            documento.Load(ruta);

            //Obtenemos una colección con todos los estudiantes.
            XmlNodeList listaEstudiantes = documento.SelectNodes("estudiantes/estudiante");

            //Creamos un único estudiante.
            XmlNode Est;

            //Recorremos toda la lista de estudiantes.
            for (int i = 0; i < listaEstudiantes.Count; i++)
            {
                //Obtenemos cada estudiante.
                Est = listaEstudiantes.Item(i);

                //Seleccionamos el id del estudiante.
                string codEstudiante = Est.SelectSingleNode("codEstudiante").InnerText;

                //Comprobamos que el id del estudiante sea el mismo que el número introducido por el usuario.
                if (codEstudiante == idEstudiante)
                {
                    //Ponemos campo id como solo lectura
                    txt_Code.ReadOnly = true;

                    //Seteamos campos dentro del formulario con informacion del archivo
                    txt_Names.Text = Est.SelectSingleNode("nombre").InnerText;
                    txt_LastNames.Text = Est.SelectSingleNode("apellidos").InnerText;                   

                }
            }
        }

        private XmlNode CrearNodoXml(string cod, string nom, string ape)
        {
            //Creamos el nodo que deseamos insertar.
            XmlElement estudiante = documento.CreateElement("estudiante");

            //Creamos el elemento codEstudiante.
            XmlElement codEstudiante = documento.CreateElement("codEstudiante");
            codEstudiante.InnerText = cod;
            estudiante.AppendChild(codEstudiante);

            //Creamos el elemento nombre.
            XmlElement nombre = documento.CreateElement("nombre");
            nombre.InnerText = nom;
            estudiante.AppendChild(nombre);

            //Creamos el elemento apellidos.
            XmlElement apellidos = documento.CreateElement("apellidos");
            apellidos.InnerText = ape;
            estudiante.AppendChild(apellidos);

            return estudiante;
        }

        private void InsertarXml()
        {
            //Cargamos el documento XML.
            documento = new XmlDocument();

            documento.Load(ruta);

            //Creamos el nodo que deseamos insertar.
            XmlNode estudiante = this.CrearNodoXml(txt_Code.Text, txt_Names.Text, txt_LastNames.Text);

            //Obtenemos el nodo raiz del documento.
            XmlNode nodoRaiz = documento.DocumentElement;

            //Insertamos el nodo estudiante al final del archivo
            nodoRaiz.InsertAfter(estudiante, nodoRaiz.LastChild);   //***

            documento.Save(ruta);

        }

        public void ModificarDatosXml(string cod, string nom, string ape)
        {
            //Cargamos el documento XML.
            documento = new XmlDocument();
            documento.Load(ruta);

            //Obtenemos el nodo raiz del documento.
            XmlElement estudiantes = documento.DocumentElement;

            //Obtenemos la lista de todos los estudiantes.
            XmlNodeList listaEstudiantes = documento.SelectNodes("estudiantes/estudiante");

            foreach (XmlNode item in listaEstudiantes)
            {
                //Determinamos el nodo a modificar por medio del id del estudiante.
                if (item.FirstChild.InnerText == cod)
                {
                    //Nodo sustituido.
                    XmlNode nodoOld = item;

                    //Nodo nuevo.
                    XmlNode nodoNew = CrearNodoXml(cod, nom, ape);

                    //Remplazamos el nodo.
                    estudiantes.ReplaceChild(nodoNew, nodoOld);

                }
            }

            //Salvamos el documento.
            documento.Save(ruta);
        }

        private void Clear()
        {
            txt_Code.ReadOnly = false;
            txt_Code.Text = "";
            txt_Names.Text = "";
            txt_LastNames.Text = "";
        }

        private void txt_Code_Leave(object sender, EventArgs e)
        {
            if (txt_Code.Text != "")
            {
                ObtenerEstudiante(txt_Code.Text);
            }
        }
    }
}
