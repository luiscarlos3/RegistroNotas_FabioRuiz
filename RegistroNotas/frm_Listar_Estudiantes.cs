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
    public partial class frm_Listar_Estudiantes : Form
    {
        static string ruta = @"..\..\Data\Estudiantes.xml";
        public frm_Listar_Estudiantes()
        {
            InitializeComponent();
        }

        private void frm_Listar_Estudiantes_Load(object sender, EventArgs e)
        {
            cargarGrillaEstudiantes();
        }

        public void cargarGrillaEstudiantes()
        {
            //Creamos un documento y lo cargamos con los datos del XML.
            XmlDocument documento = new XmlDocument();
            documento.Load(ruta);

            //Obtenemos una colección con todos los estudiantes.
            XmlNodeList listaEstudiantes = documento.SelectNodes("estudiantes/estudiante");

            //Creamos un único curso.
            XmlNode Est;

            //Limpiamos datagridview
            dgv.Rows.Clear();
            //Recorremos toda la lista de estudiantes.
            for (int i = 0; i < listaEstudiantes.Count; i++)
            {
                //Obtenemos cada curso.
                Est = listaEstudiantes.Item(i);

                //Obtenemos valores para cada fila             
                string cod = Est.SelectSingleNode("codEstudiante").InnerText;
                string nom = Est.SelectSingleNode("nombre").InnerText;
                string ape = Est.SelectSingleNode("apellidos").InnerText;

                //Insertamos nueva fila en datagridview
                dgv.Rows.Add(cod, nom, ape, "Eliminar");
                dgv.Update();

            }
        }

        public void eliminarEstudiante(string idEstudiante)
        {
            //Creamos un documento y lo cargamos con los datos del XML.
            XmlDocument documento = new XmlDocument();
            documento.Load(ruta);

            //Obtenemos el nodo raiz del documento.
            XmlElement estudiantes = documento.DocumentElement;

            //Obtenemos una colección con todos los estudiantes.
            XmlNodeList listaEstudiantes = documento.SelectNodes("estudiantes/estudiante");

            //Creamos un único estudiante.
            XmlNode Est;

            //Recorremos toda la lista de estudiantes.
            for (int i = 0; i < listaEstudiantes.Count; i++)
            {
                //Obtenemos cada estudiante.
                Est = listaEstudiantes.Item(i);

                //Seleccionamos el id del curso.
                string codEstudiante = Est.SelectSingleNode("codEstudiante").InnerText;

                //Comprobamos que el id del estudiante sea el mismo que el número introducido por el usuario.
                if (codEstudiante == idEstudiante)
                {
                    //Borrar un nodo.
                    estudiantes.RemoveChild(Est);
                }
            }

            //Salvamos el documento.
            documento.Save(ruta);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv.Columns["action"].Index)
            {
                //Do something with your button.
                string codCurso = (String)dgv.CurrentRow.Cells["codEstudiante"].Value;
                eliminarEstudiante(codCurso);
                cargarGrillaEstudiantes();
            }
        }
    }
}
