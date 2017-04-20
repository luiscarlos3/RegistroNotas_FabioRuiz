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

namespace AgendaCitas
{
    public partial class frm_Listar_Pacientes : Form
    {
        static string ruta = @"..\..\Data\Pacientes.xml";
        public frm_Listar_Pacientes()
        {
            InitializeComponent();
        }

        private void frm_Listar_Pacientes_Load(object sender, EventArgs e)
        {
            cargarGrillaPacientes();
        }

        public void cargarGrillaPacientes()
        {
            //Creamos un documento y lo cargamos con los datos del XML.
            XmlDocument documento = new XmlDocument();
            documento.Load(ruta);

            //Obtenemos una colección con todos los pacientes.
            XmlNodeList listaPacientes = documento.SelectNodes("pacientes/paciente");

            //Creamos un único profesional.
            XmlNode Pac;

            //Limpiamos datagridview
            dgv.Rows.Clear();
            //Recorremos toda la lista de pacientes.
            for (int i = 0; i < listaPacientes.Count; i++)
            {
                //Obtenemos cada profesional.
                Pac = listaPacientes.Item(i);

                //Obtenemos valores para cada fila             
                string idPac = Pac.SelectSingleNode("idPaciente").InnerText;
                string nom = Pac.SelectSingleNode("nombre").InnerText;
                string ape = Pac.SelectSingleNode("apellidos").InnerText;
                string dir = Pac.SelectSingleNode("direccion").InnerText;
                string tel = Pac.SelectSingleNode("telefono").InnerText;
                string mail = Pac.SelectSingleNode("correo").InnerText;

                //Insertamos nueva fila en datagridview
                dgv.Rows.Add(idPac, nom, ape, dir, tel, mail, "Eliminar");
                dgv.Update();

            }
        }

        public void eliminarPaciente(string idPaciente)
        {
            //Creamos un documento y lo cargamos con los datos del XML.
            XmlDocument documento = new XmlDocument();
            documento.Load(ruta);

            //Obtenemos el nodo raiz del documento.
            XmlElement pacientes = documento.DocumentElement;

            //Obtenemos una colección con todos los pacientes.
            XmlNodeList listaPacientes = documento.SelectNodes("pacientes/paciente");

            //Creamos un único empleado.
            XmlNode Paciente;

            //Recorremos toda la lista de pacientes.
            for (int i = 0; i < listaPacientes.Count; i++)
            {
                //Obtenemos cada paciente.
                Paciente = listaPacientes.Item(i);

                //Seleccionamos el id del paciente.
                string numPaciente = Paciente.SelectSingleNode("idPaciente").InnerText;

                //Comprobamos que el id del paciente sea el mismo que el número introducido por el usuario.
                if (numPaciente == idPaciente)
                {
                    //Borrar un nodo.
                    pacientes.RemoveChild(Paciente);
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
                string idPaciente = (String)dgv.CurrentRow.Cells["idPaciente"].Value;
                eliminarPaciente(idPaciente);
                cargarGrillaPacientes();
            }
        }

    }
}
