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
    public partial class frm_Add_Notas : Form
    {
        XmlDocument documento;
        static string ruta = @"..\..\Data\Notas.xml";
        static string rutaEst = @"..\..\Data\Estudiantes.xml";
        static string rutaCurso = @"..\..\Data\Cursos.xml";
        public frm_Add_Notas()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Validamos campos llenos
            if (txt_Code.Text == "" || txt_FullName.Text == "" || txt_Score1.Text == "" || txt_Score2.Text == "" || cbo_Curso.SelectedIndex == -1)
            {
                MessageBox.Show("Debe llenar todos los campos", "Registro de Notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if (Convert.ToDouble(txt_Score1.Text) > 375) {
                MessageBox.Show(lbl_Score1.Text + " no puede ser superior a 375", "Registro de Notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if (Convert.ToDouble(txt_Score2.Text) > 125)
            {
                MessageBox.Show(lbl_Score2.Text + " no puede ser superior a 125", "Registro de Notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            InsertarXml();
            Clear();
            //MessageBox.Show("Datos guardados", "Registro de Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ObtenerEstudiante(string idEstudiante)
        {
            //Creamos un documento y lo cargamos con los datos del XML.
            XmlDocument documento = new XmlDocument();
            documento.Load(rutaEst);

            //Obtenemos una colección con todos los estudiantes.
            XmlNodeList listaEstudiantes = documento.SelectNodes("estudiantes/estudiante");

            //Creamos un único estudiante.
            XmlNode Estudiante;

            //Recorremos toda la lista de estudiantes.
            for (int i = 0; i < listaEstudiantes.Count; i++)
            {
                //Obtenemos cada estudiante.
                Estudiante = listaEstudiantes.Item(i);

                //Seleccionamos el código del estudiante.
                string codEstudiante = Estudiante.SelectSingleNode("codEstudiante").InnerText;

                //Comprobamos que el id del estudiante sea el mismo que el número introducido por el usuario.
                if (codEstudiante == idEstudiante)
                {
                    //Ponemos campo id como solo lectura
                    txt_Code.ReadOnly = true;

                    //Seteamos campos dentro del formulario con informacion del archivo
                    txt_FullName.Text = Estudiante.SelectSingleNode("nombre").InnerText + " " + Estudiante.SelectSingleNode("apellidos").InnerText;
                }
            }
        }

        private XmlNode CrearNodoXml(string fec, string hora,string cod, string nom, string curso, string nota1, string nota2, double nota_def, string result)
        {
            //Creamos el nodo que deseamos insertar.
            XmlElement nota = documento.CreateElement("nota");

            //Creamos el elemento fecha consulta.
            XmlElement fecha_consulta = documento.CreateElement("fecha_consulta");
            fecha_consulta.InnerText = fec;
            nota.AppendChild(fecha_consulta);

            //Creamos el elemento hora consulta.
            XmlElement hora_consulta = documento.CreateElement("hora_consulta");
            hora_consulta.InnerText = hora;
            nota.AppendChild(hora_consulta);

            //Creamos el elemento codEstudiante.
            XmlElement codEstudiante = documento.CreateElement("codEstudiante");
            codEstudiante.InnerText = cod;
            nota.AppendChild(codEstudiante);

            //Creamos el elemento nombre.
            XmlElement nombre = documento.CreateElement("nombre");
            nombre.InnerText = nom;
            nota.AppendChild(nombre);

            //Creamos el elemento curso.
            XmlElement nom_curso = documento.CreateElement("nombre_curso");
            nom_curso.InnerText = curso;
            nota.AppendChild(nom_curso);

            //Creamos el elemento calificacion 1.
            XmlElement calif_1 = documento.CreateElement("calificacion1");
            calif_1.InnerText = nota1;
            nota.AppendChild(calif_1);

            //Creamos el elemento calificacion 2.
            XmlElement calif_2 = documento.CreateElement("calificacion2");
            calif_2.InnerText = nota2;
            nota.AppendChild(calif_2);

            //Creamos el elemento calificacion Definitiva.
            XmlElement califDef = documento.CreateElement("calificacionDef");
            califDef.InnerText = nota_def.ToString();
            nota.AppendChild(califDef);

            //Creamos el elemento resultado.
            XmlElement resultado = documento.CreateElement("resultado");
            resultado.InnerText = result;
            nota.AppendChild(resultado);

            return nota;
        }

        private void InsertarXml()
        {
            //Cargamos el documento XML.
            documento = new XmlDocument();

            documento.Load(ruta);
            DateTime Hoy = DateTime.Today;

            string fecha_actual = Hoy.ToString("dd-MM-yyyy");
            string hora_actual = DateTime.Now.ToShortTimeString();
            double nota_def = calcularNotaFinal(Convert.ToDouble(txt_Score1.Text),Convert.ToDouble(txt_Score2.Text));
            String resultado = (nota_def < 3) ? "NO APROBADO" : "APROBADO";
            String msjResult = (nota_def < 3) ? "EL CURSO NO HA SIDO APROBADO" : "EL CURSO HA SIDO APROBADO";

            //Creamos el nodo que deseamos insertar.
            XmlNode nota = this.CrearNodoXml(fecha_actual, hora_actual, txt_Code.Text, txt_FullName.Text, cbo_Curso.SelectedItem.ToString(), txt_Score1.Text, txt_Score2.Text, nota_def, resultado);

            //Obtenemos el nodo raiz del documento.
            XmlNode nodoRaiz = documento.DocumentElement;

            //Insertamos el nodo nota al final del archivo
            nodoRaiz.InsertAfter(nota, nodoRaiz.LastChild);   //***

            documento.Save(ruta);

            MessageBox.Show("SU NOTA DEFINITIVA FUE: " + nota_def + ". " + msjResult, "Registro de Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Clear()
        {
            txt_Code.ReadOnly = false;
            txt_Code.Text = "";
            txt_FullName.Text = "";
            txt_Score1.Text = "";
            txt_Score2.Text = "";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Add_Notas_Load(object sender, EventArgs e)
        {
            cargarListaCursos();
        }

        public void cargarListaCursos()
        {
            //Creamos un documento y lo cargamos con los datos del XML.
            XmlDocument documento = new XmlDocument();
            documento.Load(rutaCurso);

            //Obtenemos una colección con todos los cursos.
            XmlNodeList listaCursos = documento.SelectNodes("cursos/curso");

            //Creamos un único curso.
            XmlNode Curso;

            //Limpiamos la lista
            cbo_Curso.Items.Clear();
            //Recorremos toda la lista de cursos.
            for (int i = 0; i < listaCursos.Count; i++)
            {
                //Obtenemos cada profesional.
                Curso = listaCursos.Item(i);

                //Obtenemos valores para cada fila             
                string nomCurso = Curso.SelectSingleNode("descripcion").InnerText;

                //Insertamos regisro en combo
                cbo_Curso.Items.Add(nomCurso);

            }
        }

        private void txt_Code_Leave(object sender, EventArgs e)
        {
            if (txt_Code.Text != "")
            {
                ObtenerEstudiante(txt_Code.Text);
            }
        }

        private double calcularNotaFinal(double nota1, double nota2) {
            double notaFinal = 0.0;

            notaFinal = (nota1 * 5 / 375) * 0.75 + (nota2 * 5 / 125) * 0.25;

            return notaFinal;
        }

    }
}
