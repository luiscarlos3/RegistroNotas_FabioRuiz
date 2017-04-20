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
    public partial class frm_Add_Curso : Form
    {
        XmlDocument documento;
        static string ruta = @"..\..\Data\Cursos.xml";
        public frm_Add_Curso()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Validamos campos llenos
            if (txt_Code.Text == "" || txt_Description.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Registro de Notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_Code.ReadOnly)
            {
                ModificarDatosXml(txt_Code.Text, txt_Description.Text);
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

        public void ObtenerCurso(string idCurso)
        {
            //Creamos un documento y lo cargamos con los datos del XML.
            XmlDocument documento = new XmlDocument();
            documento.Load(ruta);

            //Obtenemos una colección con todos los cursos.
            XmlNodeList listaCursos = documento.SelectNodes("cursos/curso");

            //Creamos un único curso.
            XmlNode Curso;

            //Recorremos toda la lista de profesionales.
            for (int i = 0; i < listaCursos.Count; i++)
            {
                //Obtenemos cada curso.
                Curso = listaCursos.Item(i);

                //Seleccionamos el id del curso.
                string codCurso = Curso.SelectSingleNode("codCurso").InnerText;

                //Comprobamos que el id del curso sea el mismo que el número introducido por el usuario.
                if (codCurso == idCurso)
                {
                    //Ponemos campo id como solo lectura
                    txt_Code.ReadOnly = true;

                    //Seteamos campos dentro del formulario con informacion del archivo
                    txt_Description.Text = Curso.SelectSingleNode("descripcion").InnerText;
                   
                }
            }
        }

        private XmlNode CrearNodoXml(string codigo, string desc)
        {
            //Creamos el nodo que deseamos insertar.
            XmlElement curso = documento.CreateElement("curso");

            //Creamos el elemento codCurso.
            XmlElement codCurso = documento.CreateElement("codCurso");
            codCurso.InnerText = codigo;
            curso.AppendChild(codCurso);

            //Creamos el elemento descripcion.
            XmlElement descripcion = documento.CreateElement("descripcion");
            descripcion.InnerText = desc;
            curso.AppendChild(descripcion);

            
            return curso;
        }

        private void InsertarXml()
        {
            //Cargamos el documento XML.
            documento = new XmlDocument();

            documento.Load(ruta);

            //Creamos el nodo que deseamos insertar.
            XmlNode curso = this.CrearNodoXml(txt_Code.Text, txt_Description.Text);

            //Obtenemos el nodo raiz del documento.
            XmlNode nodoRaiz = documento.DocumentElement;

            //Insertamos el nodo curso al final del archivo
            nodoRaiz.InsertAfter(curso, nodoRaiz.LastChild);   //***

            documento.Save(ruta);

        }

        public void ModificarDatosXml(string codigo, string desc)
        {
            //Cargamos el documento XML.
            documento = new XmlDocument();
            documento.Load(ruta);

            //Obtenemos el nodo raiz del documento.
            XmlElement cursos = documento.DocumentElement;

            //Obtenemos la lista de todos los cursos.
            XmlNodeList listaCursos = documento.SelectNodes("cursos/curso");

            foreach (XmlNode item in listaCursos)
            {
                //Determinamos el nodo a modificar por medio del id del curso.
                if (item.FirstChild.InnerText == codigo)
                {
                    //Nodo sustituido.
                    XmlNode nodoOld = item;

                    //Nodo nuevo.
                    XmlNode nodoNew = CrearNodoXml(codigo, desc);

                    //Remplazamos el nodo.
                    cursos.ReplaceChild(nodoNew, nodoOld);

                }
            }

            //Salvamos el documento.
            documento.Save(ruta);
        }

        private void Clear()
        {
            txt_Code.ReadOnly = false;
            txt_Code.Text = "";
            txt_Description.Text = "";           
        }

        private void txt_Code_Leave(object sender, EventArgs e)
        {
            if (txt_Code.Text != "")
            {
                ObtenerCurso(txt_Code.Text);
            }
        }

    }
}
