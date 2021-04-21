using ColegioForms.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColegioForms
{
    public partial class GuiForm : Form
    {
        public GuiForm()
        {
            InitializeComponent();
        }

        private void GuiForm_Load(object sender, EventArgs e)
        {
            //el codigo que debemos establecer aca 
            //se ejecutara al iniciar la ventana

            //Primero voy a crear la conexion el contextBD creada

            ContextBD bd = new ContextBD();

            gridCursos.DataSource = bd.Cursos.ToList();
        }
    }
}
