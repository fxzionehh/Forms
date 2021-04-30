
namespace ColegioForms
{
    partial class GuiForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridAlumnos = new System.Windows.Forms.DataGridView();
            this.comboCursos = new System.Windows.Forms.ComboBox();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAlumnos
            // 
            this.gridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlumnos.Location = new System.Drawing.Point(212, 182);
            this.gridAlumnos.Name = "gridAlumnos";
            this.gridAlumnos.Size = new System.Drawing.Size(289, 194);
            this.gridAlumnos.TabIndex = 0;
            this.gridAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCursos_CellContentClick);
            // 
            // comboCursos
            // 
            this.comboCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCursos.FormattingEnabled = true;
            this.comboCursos.Location = new System.Drawing.Point(57, 125);
            this.comboCursos.Name = "comboCursos";
            this.comboCursos.Size = new System.Drawing.Size(121, 21);
            this.comboCursos.TabIndex = 1;
            this.comboCursos.SelectedIndexChanged += new System.EventHandler(this.comboProfesores_SelectedIndexChanged);
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnos.Location = new System.Drawing.Point(305, 141);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(102, 25);
            this.lblAlumnos.TabIndex = 2;
            this.lblAlumnos.Text = "Alumnos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cursos";
            // 
            // GuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.comboCursos);
            this.Controls.Add(this.gridAlumnos);
            this.Name = "GuiForm";
            this.Text = "Simulador de Creditos";
            this.Load += new System.EventHandler(this.GuiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAlumnos;
        private System.Windows.Forms.ComboBox comboCursos;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Label label1;
    }
}

