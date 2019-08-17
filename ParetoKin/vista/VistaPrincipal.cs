using ParetoKin.modelo;
using ParetoKin.vista;
using ParetoKin.vista.modulohorarios;
using ParetoKin.vista.modulohoy;
using ParetoKin.vista.modulomatriz;
using ParetoKin.vista.modulotareas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParetoKin
{
    public partial class VistaPrincipal : Form
    {
        public Form form_generico;
        public bool aplicacionAbierta;
        Loggin padre;
        public VistaPrincipal(Loggin padre)
        {
            InitializeComponent();

            this.padre = padre;
            this.buttonSalir.Text = Program.str.diccionario["buttonSalir"];
            this.buttonCerrarSesion.Text = Program.str.diccionario["buttonCerrarSesion"];

            
            this.buttonTareas.Text = Program.str.diccionario["buttonTareas"];
            this.buttonHorarios.Text = Program.str.diccionario["buttonHorarios"];
            this.buttonHoy.Text = Program.str.diccionario["Hoy"];
            this.buttonMatriz.Text = Program.str.diccionario["buttonMatriz"];

            this.labelAprender.Text = Program.str.diccionario["labelAprender"];
            this.labelPracticar.Text = Program.str.diccionario["labelPracticar"];
            this.labelAplicar.Text = Program.str.diccionario["labelAplicar"];

            DateTime src = DateTime.Now;

            this.labelFecha.Text = Fecha.day2dia("" + src.DayOfWeek) + ", " + src.Day + " " + Program.str.diccionario["de"] + " " + Fecha.month2mes(src.Month) + " " + Program.str.diccionario["del"] + " " + src.Year;

            aplicacionAbierta = true;

            CheckForIllegalCrossThreadCalls = false;
            //Creamos el delegado 
            ThreadStart delegado = new ThreadStart(mostrarHora);
            //Creamos la instancia del hilo 
            Thread hilo = new Thread(delegado);
            //Iniciamos el hilo 
            hilo.Start();


        }

        public void mostrarHora()
        {
            while (aplicacionAbierta)
            {
                DateTime src = DateTime.Now;
                this.labelHora.Text = ((src.Hour < 10)? "0"+ src.Hour: ""+src.Hour) + ":" + ((src.Minute < 10) ? "0" + src.Minute : "" + src.Minute) + ":" + ((src.Second < 10) ? "0" + src.Second : "" + src.Second);
                Thread.Sleep(500);
            }
            
        }


        


        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            cierreSeguro();
        }

        public void cierreSeguro()
        {
            aplicacionAbierta = false;
            form_generico?.Close();
            Application.Exit();
        }

        private void ButtonTareas_Click(object sender, EventArgs e)
        {
            ocultarInicio();
            this.buttonHoy.BackColor = Program.colorBotonGenerico;
            this.buttonMatriz.BackColor = Program.colorBotonGenerico;
            this.buttonTareas.BackColor = Program.colorBotonSeleccionado;
            this.buttonHorarios.BackColor = Program.colorBotonGenerico;

            this.labelTitulo.Text = Program.str.diccionario["buttonTareas"];


            form_generico?.Close();
            form_generico = new TareasMain(this) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelGenerico.Controls.Add(form_generico);
            form_generico.Show();

        }

        private void ButtonHorarios_Click(object sender, EventArgs e)
        {
            ocultarInicio();
            this.buttonHoy.BackColor = Program.colorBotonGenerico;
            this.buttonMatriz.BackColor = Program.colorBotonGenerico;
            this.buttonTareas.BackColor = Program.colorBotonGenerico;
            this.buttonHorarios.BackColor = Program.colorBotonSeleccionado;

            this.labelTitulo.Text = Program.str.diccionario["buttonHorarios"];



            form_generico?.Close();
            form_generico = new HorariosMain(this) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelGenerico.Controls.Add(form_generico);
            form_generico.Show();
        }

        private void ButtonMatriz_Click(object sender, EventArgs e)
        {
            ocultarInicio();
            this.buttonHoy.BackColor = Program.colorBotonGenerico;
            this.buttonMatriz.BackColor = Program.colorBotonSeleccionado;
            this.buttonTareas.BackColor = Program.colorBotonGenerico;
            this.buttonHorarios.BackColor = Program.colorBotonGenerico;


            this.labelTitulo.Text = Program.str.diccionario["buttonMatriz"];



            form_generico?.Close();
            form_generico = new MatrizMain(this) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelGenerico.Controls.Add(form_generico);
            form_generico.Show();
        }

        private void cierreSeguro(object sender, FormClosedEventArgs e)
        {
            cierreSeguro();
        }

        private void ButtonHoy_Click(object sender, EventArgs e)
        {
            ocultarInicio();
            this.buttonHoy.BackColor = Program.colorBotonSeleccionado;
            this.buttonMatriz.BackColor = Program.colorBotonGenerico;
            this.buttonTareas.BackColor = Program.colorBotonGenerico;
            this.buttonHorarios.BackColor = Program.colorBotonGenerico;

            this.labelTitulo.Text = Program.str.diccionario["Hoy"];



            form_generico?.Close();
            form_generico = new HoyMain(this) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panelGenerico.Controls.Add(form_generico);
            form_generico.Show();
        }

        public void ocultarInicio()
        {
            this.labelSystema.Visible = false;
            this.pictureBoxLogoSystema.Visible = false;

            this.labelAplicar.Visible = false;
            this.labelAprender.Visible = false;
            this.labelPracticar.Visible = false;
            this.labelMagia.Visible = false;
            this.labelSuNombre.Visible = false;
            this.labelAyudar.Visible = false;

            

        }

        public void mostrarInicio()
        {
            this.labelSystema.Visible = true;
            this.pictureBoxLogoSystema.Visible = true;

            this.labelAplicar.Visible = true;
            this.labelAprender.Visible = true;
            this.labelPracticar.Visible = true;
            this.labelMagia.Visible = true;
            this.labelSuNombre.Visible = true;
            this.labelAyudar.Visible = true;

            labelTitulo.Text = "ParettoKin";

            this.buttonHoy.BackColor = Program.colorBotonGenerico;
            this.buttonMatriz.BackColor = Program.colorBotonGenerico;
            this.buttonTareas.BackColor = Program.colorBotonGenerico;
            this.buttonHorarios.BackColor = Program.colorBotonGenerico;
        }


        private void ButtonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            padre.Show();
        }
    }
}


