namespace RegistroNotas
{
    partial class frm_Listar_Consultas
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.fecha_consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota_def = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha_consulta,
            this.hora_consulta,
            this.cod_estudiante,
            this.nombre,
            this.curso,
            this.nota1,
            this.nota2,
            this.nota_def,
            this.resultado});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(935, 313);
            this.dgv.TabIndex = 3;
            // 
            // fecha_consulta
            // 
            this.fecha_consulta.HeaderText = "Fecha Consulta";
            this.fecha_consulta.Name = "fecha_consulta";
            // 
            // hora_consulta
            // 
            this.hora_consulta.HeaderText = "Hora Consulta";
            this.hora_consulta.Name = "hora_consulta";
            // 
            // cod_estudiante
            // 
            this.cod_estudiante.HeaderText = "Cód. Estudiante";
            this.cod_estudiante.Name = "cod_estudiante";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // curso
            // 
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            // 
            // nota1
            // 
            this.nota1.HeaderText = "Puntos 75%";
            this.nota1.Name = "nota1";
            // 
            // nota2
            // 
            this.nota2.HeaderText = "Puntos 25%";
            this.nota2.Name = "nota2";
            // 
            // nota_def
            // 
            this.nota_def.HeaderText = "Nota Defiitiva";
            this.nota_def.Name = "nota_def";
            // 
            // resultado
            // 
            this.resultado.HeaderText = "Estado";
            this.resultado.Name = "resultado";
            // 
            // frm_Listar_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 337);
            this.Controls.Add(this.dgv);
            this.Name = "frm_Listar_Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Consultas";
            this.Load += new System.EventHandler(this.frm_Listar_Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota_def;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultado;
    }
}