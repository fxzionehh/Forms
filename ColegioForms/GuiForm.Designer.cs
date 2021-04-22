
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
            this.comboProfesores = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAlumnos
            // 
            this.gridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlumnos.Location = new System.Drawing.Point(54, 249);
            this.gridAlumnos.Name = "gridAlumnos";
            this.gridAlumnos.Size = new System.Drawing.Size(451, 129);
            this.gridAlumnos.TabIndex = 0;
            this.gridAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCursos_CellContentClick);
            // 
            // comboProfesores
            // 
            this.comboProfesores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProfesores.FormattingEnabled = true;
            this.comboProfesores.Location = new System.Drawing.Point(344, 157);
            this.comboProfesores.Name = "comboProfesores";
            this.comboProfesores.Size = new System.Drawing.Size(121, 21);
            this.comboProfesores.TabIndex = 1;
            this.comboProfesores.SelectedIndexChanged += new System.EventHandler(this.comboProfesores_SelectedIndexChanged);
            // 
            // GuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.comboProfesores);
            this.Controls.Add(this.gridAlumnos);
            this.Name = "GuiForm";
            this.Text = "Colegio Primavera";
            this.Load += new System.EventHandler(this.GuiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAlumnos;
        private System.Windows.Forms.ComboBox comboProfesores;
    }
}

