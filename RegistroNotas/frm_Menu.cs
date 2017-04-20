using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroNotas
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void registrarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Estudiante frm = new frm_Add_Estudiante();
            frm.Show();
        }

        private void consultarEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Listar_Estudiantes frm = new frm_Listar_Estudiantes();
            frm.Show();
        }

        private void registrarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Curso frm = new frm_Add_Curso();
            frm.Show();
        }

        private void consultarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Listar_Cursos frm = new frm_Listar_Cursos();
            frm.Show();
        }

        private void calcularPuntajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Notas frm = new frm_Add_Notas();
            frm.Show();
        }

        private void historialConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Listar_Consultas frm = new frm_Listar_Consultas();
            frm.Show();
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {

        }

      
    }
}
