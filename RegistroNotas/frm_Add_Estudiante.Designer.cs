namespace RegistroNotas
{
    partial class frm_Add_Estudiante
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
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_Names = new System.Windows.Forms.TextBox();
            this.txt_LastNames = new System.Windows.Forms.TextBox();
            this.lbl_LastNames = new System.Windows.Forms.Label();
            this.lbl_names = new System.Windows.Forms.Label();
            this.lbl_Code = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(109, 27);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(100, 20);
            this.txt_Code.TabIndex = 1;
            this.txt_Code.Leave += new System.EventHandler(this.txt_Code_Leave);
            // 
            // txt_Names
            // 
            this.txt_Names.Location = new System.Drawing.Point(109, 62);
            this.txt_Names.Name = "txt_Names";
            this.txt_Names.Size = new System.Drawing.Size(270, 20);
            this.txt_Names.TabIndex = 3;
            // 
            // txt_LastNames
            // 
            this.txt_LastNames.Location = new System.Drawing.Point(109, 93);
            this.txt_LastNames.Name = "txt_LastNames";
            this.txt_LastNames.Size = new System.Drawing.Size(270, 20);
            this.txt_LastNames.TabIndex = 5;
            // 
            // lbl_LastNames
            // 
            this.lbl_LastNames.AutoSize = true;
            this.lbl_LastNames.Location = new System.Drawing.Point(33, 93);
            this.lbl_LastNames.Name = "lbl_LastNames";
            this.lbl_LastNames.Size = new System.Drawing.Size(49, 13);
            this.lbl_LastNames.TabIndex = 4;
            this.lbl_LastNames.Text = "Apellidos";
            // 
            // lbl_names
            // 
            this.lbl_names.AutoSize = true;
            this.lbl_names.Location = new System.Drawing.Point(33, 62);
            this.lbl_names.Name = "lbl_names";
            this.lbl_names.Size = new System.Drawing.Size(49, 13);
            this.lbl_names.TabIndex = 2;
            this.lbl_names.Text = "Nombres";
            // 
            // lbl_Code
            // 
            this.lbl_Code.AutoSize = true;
            this.lbl_Code.Location = new System.Drawing.Point(33, 27);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(40, 13);
            this.lbl_Code.TabIndex = 0;
            this.lbl_Code.Text = "Código";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(263, 141);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(153, 141);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Guardar";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 187);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.txt_Names);
            this.Controls.Add(this.txt_LastNames);
            this.Controls.Add(this.lbl_LastNames);
            this.Controls.Add(this.lbl_names);
            this.Controls.Add(this.lbl_Code);
            this.Name = "frm_Add_Estudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Estudiantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.TextBox txt_Names;
        private System.Windows.Forms.TextBox txt_LastNames;
        private System.Windows.Forms.Label lbl_LastNames;
        private System.Windows.Forms.Label lbl_names;
        private System.Windows.Forms.Label lbl_Code;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
    }
}