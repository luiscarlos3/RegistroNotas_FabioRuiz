namespace RegistroNotas
{
    partial class frm_Add_Notas
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
            this.lbl_Curso = new System.Windows.Forms.Label();
            this.cbo_Curso = new System.Windows.Forms.ComboBox();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.lbl_names = new System.Windows.Forms.Label();
            this.lbl_Identification = new System.Windows.Forms.Label();
            this.txt_Score1 = new System.Windows.Forms.TextBox();
            this.lbl_Score1 = new System.Windows.Forms.Label();
            this.txt_Score2 = new System.Windows.Forms.TextBox();
            this.lbl_Score2 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Curso
            // 
            this.lbl_Curso.AutoSize = true;
            this.lbl_Curso.Location = new System.Drawing.Point(21, 26);
            this.lbl_Curso.Name = "lbl_Curso";
            this.lbl_Curso.Size = new System.Drawing.Size(34, 13);
            this.lbl_Curso.TabIndex = 16;
            this.lbl_Curso.Text = "Curso";
            // 
            // cbo_Curso
            // 
            this.cbo_Curso.FormattingEnabled = true;
            this.cbo_Curso.Location = new System.Drawing.Point(114, 18);
            this.cbo_Curso.Name = "cbo_Curso";
            this.cbo_Curso.Size = new System.Drawing.Size(114, 21);
            this.cbo_Curso.TabIndex = 17;
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(114, 58);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(113, 20);
            this.txt_Code.TabIndex = 19;
            this.txt_Code.Leave += new System.EventHandler(this.txt_Code_Leave);
            // 
            // txt_FullName
            // 
            this.txt_FullName.Location = new System.Drawing.Point(114, 95);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(345, 20);
            this.txt_FullName.TabIndex = 21;
            // 
            // lbl_names
            // 
            this.lbl_names.AutoSize = true;
            this.lbl_names.Location = new System.Drawing.Point(21, 99);
            this.lbl_names.Name = "lbl_names";
            this.lbl_names.Size = new System.Drawing.Size(91, 13);
            this.lbl_names.TabIndex = 20;
            this.lbl_names.Text = "Nombre Completo";
            // 
            // lbl_Identification
            // 
            this.lbl_Identification.AutoSize = true;
            this.lbl_Identification.Location = new System.Drawing.Point(21, 61);
            this.lbl_Identification.Name = "lbl_Identification";
            this.lbl_Identification.Size = new System.Drawing.Size(82, 13);
            this.lbl_Identification.TabIndex = 18;
            this.lbl_Identification.Text = "Cód. Estudiante";
            // 
            // txt_Score1
            // 
            this.txt_Score1.Location = new System.Drawing.Point(346, 18);
            this.txt_Score1.Name = "txt_Score1";
            this.txt_Score1.Size = new System.Drawing.Size(113, 20);
            this.txt_Score1.TabIndex = 23;
            // 
            // lbl_Score1
            // 
            this.lbl_Score1.AutoSize = true;
            this.lbl_Score1.Location = new System.Drawing.Point(253, 21);
            this.lbl_Score1.Name = "lbl_Score1";
            this.lbl_Score1.Size = new System.Drawing.Size(66, 13);
            this.lbl_Score1.TabIndex = 22;
            this.lbl_Score1.Text = "Puntaje 75%";
            // 
            // txt_Score2
            // 
            this.txt_Score2.Location = new System.Drawing.Point(346, 54);
            this.txt_Score2.Name = "txt_Score2";
            this.txt_Score2.Size = new System.Drawing.Size(113, 20);
            this.txt_Score2.TabIndex = 25;
            // 
            // lbl_Score2
            // 
            this.lbl_Score2.AutoSize = true;
            this.lbl_Score2.Location = new System.Drawing.Point(253, 57);
            this.lbl_Score2.Name = "lbl_Score2";
            this.lbl_Score2.Size = new System.Drawing.Size(66, 13);
            this.lbl_Score2.TabIndex = 24;
            this.lbl_Score2.Text = "Puntaje 25%";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(262, 139);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 27;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(152, 139);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(92, 23);
            this.btn_Save.TabIndex = 26;
            this.btn_Save.Text = "Calcular Nota";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 186);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Score2);
            this.Controls.Add(this.lbl_Score2);
            this.Controls.Add(this.txt_Score1);
            this.Controls.Add(this.lbl_Score1);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.txt_FullName);
            this.Controls.Add(this.lbl_names);
            this.Controls.Add(this.lbl_Identification);
            this.Controls.Add(this.lbl_Curso);
            this.Controls.Add(this.cbo_Curso);
            this.Name = "frm_Add_Notas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Calificaciones";
            this.Load += new System.EventHandler(this.frm_Add_Notas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Curso;
        private System.Windows.Forms.ComboBox cbo_Curso;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.Label lbl_names;
        private System.Windows.Forms.Label lbl_Identification;
        private System.Windows.Forms.TextBox txt_Score1;
        private System.Windows.Forms.Label lbl_Score1;
        private System.Windows.Forms.TextBox txt_Score2;
        private System.Windows.Forms.Label lbl_Score2;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
    }
}