namespace RegistroNotas
{
    partial class frm_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularPuntajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursosToolStripMenuItem,
            this.estudiantesToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCursosToolStripMenuItem,
            this.consultarCursosToolStripMenuItem});
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // registrarCursosToolStripMenuItem
            // 
            this.registrarCursosToolStripMenuItem.Name = "registrarCursosToolStripMenuItem";
            this.registrarCursosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.registrarCursosToolStripMenuItem.Text = "Registrar Curso";
            this.registrarCursosToolStripMenuItem.Click += new System.EventHandler(this.registrarCursosToolStripMenuItem_Click);
            // 
            // consultarCursosToolStripMenuItem
            // 
            this.consultarCursosToolStripMenuItem.Name = "consultarCursosToolStripMenuItem";
            this.consultarCursosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.consultarCursosToolStripMenuItem.Text = "Consultar Cursos";
            this.consultarCursosToolStripMenuItem.Click += new System.EventHandler(this.consultarCursosToolStripMenuItem_Click);
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEstudianteToolStripMenuItem,
            this.consultarEstudiantesToolStripMenuItem});
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            // 
            // registrarEstudianteToolStripMenuItem
            // 
            this.registrarEstudianteToolStripMenuItem.Name = "registrarEstudianteToolStripMenuItem";
            this.registrarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.registrarEstudianteToolStripMenuItem.Text = "Registrar Estudiante";
            this.registrarEstudianteToolStripMenuItem.Click += new System.EventHandler(this.registrarEstudianteToolStripMenuItem_Click);
            // 
            // consultarEstudiantesToolStripMenuItem
            // 
            this.consultarEstudiantesToolStripMenuItem.Name = "consultarEstudiantesToolStripMenuItem";
            this.consultarEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.consultarEstudiantesToolStripMenuItem.Text = "Consultar Estudiantes";
            this.consultarEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.consultarEstudiantesToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularPuntajeToolStripMenuItem,
            this.historialConsultasToolStripMenuItem});
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // calcularPuntajeToolStripMenuItem
            // 
            this.calcularPuntajeToolStripMenuItem.Name = "calcularPuntajeToolStripMenuItem";
            this.calcularPuntajeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.calcularPuntajeToolStripMenuItem.Text = "Calcular Puntaje";
            this.calcularPuntajeToolStripMenuItem.Click += new System.EventHandler(this.calcularPuntajeToolStripMenuItem_Click);
            // 
            // historialConsultasToolStripMenuItem
            // 
            this.historialConsultasToolStripMenuItem.Name = "historialConsultasToolStripMenuItem";
            this.historialConsultasToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.historialConsultasToolStripMenuItem.Text = "Historial Consultas";
            this.historialConsultasToolStripMenuItem.Click += new System.EventHandler(this.historialConsultasToolStripMenuItem_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa de notas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularPuntajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialConsultasToolStripMenuItem;
    }
}