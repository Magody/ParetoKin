using ParetoKin.vista.modulotareas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParetoKin
{
    public partial class VistaPrincipal : Form
    {
        public Form form_generico;
        public VistaPrincipal()
        {
            InitializeComponent();
            this.buttonSalir.Text = Program.str.diccionario["buttonSalir"];
            this.buttonTareas.Text = Program.str.diccionario["buttonTareas"];
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonTareas_Click(object sender, EventArgs e)
        {
            form_generico?.Close();
            form_generico = new TareasMain(this) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelGenerico.Controls.Add(form_generico);
            form_generico.Show();

        }
    }
}


