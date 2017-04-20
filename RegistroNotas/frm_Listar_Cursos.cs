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
    public partial class frm_Listar_Cursos : Form
    {
        static string ruta = @"..\..\Data\Cursos.xml";
        public frm_Listar_Cursos()
        {
            InitializeComponent();
        }

        private void frm_Listar_Cursos_Load(object sender, EventArgs e)
        {
            cargarGrillaCursos();
        }

        public void cargarGrillaCursos()
        {
            //Creamos un documento y lo cargamos con los datos del XML.
            XmlDocument documento = new XmlDocument();
            documento.Load(ruta);

            //Obtenemos una colección con todos los cursos.
            XmlNodeList listaCursos = documento.SelectNodes("cursos/curso");

            //Creamos un único curso.
            XmlNode Curso;

            //Limpiamos datagridview
            dgv.Rows.Clear();
            //Recorremos toda la lista de cursos.
            for (int i = 0; i < listaCursos.Count; i++)
            {
                //Obtenemos cada curso.
                Curso = listaCursos.Item(i);

                //Obtenemos valores para cada fila             
                string cod = Curso.SelectSingleNode("codCurso").InnerText;
                string desc = Curso.SelectSingleNode("descripcion").InnerText;
              
                //Insertamos nueva fila en datagridview
                dgv.Rows.Add(cod, desc, "Eliminar");
                dgv.Update();

            }
        }

        public void eliminarCurso(string idCurso)
        {
            //Creamos un documento y lo cargamos con los datos del XML.
            XmlDocument documento = new XmlDocument();
            documento.Load(ruta);

            //Obtenemos el nodo raiz del documento.
            XmlElement cursos = documento.DocumentElement;

            //Obtenemos una colección con todos los cursos.
            XmlNodeList listaCursos = documento.SelectNodes("cursos/curso");

            //Creamos un único curso.
            XmlNode Curso;

            //Recorremos toda la lista de cursos.
            for (int i = 0; i < listaCursos.Count; i++)
            {
                //Obtenemos cada curso.
                Curso = listaCursos.Item(i);

                //Seleccionamos el id del curso.
                string codCurso = Curso.SelectSingleNode("codCurso").InnerText;

                //Comprobamos que el id del paciente sea el mismo que el número introducido por el usuario.
                if (codCurso == idCurso)
                {
                    //Borrar un nodo.
                    cursos.RemoveChild(Curso);
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
                string codCurso = (String)dgv.CurrentRow.Cells["codCurso"].Value;
                eliminarCurso(codCurso);
                cargarGrillaCursos();
            }
        }

    }
}
