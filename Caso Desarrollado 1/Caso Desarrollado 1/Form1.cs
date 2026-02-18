using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso_Desarrollado_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Promedio objP = new Promedio();

            objP.alumno = txtAlumno.Text;
            objP.nota1 = int.Parse(txtNota1.Text);
            objP.nota2 = int.Parse(txtNota2.Text);
            objP.nota3 = int.Parse(txtNota3.Text);
            objP.nota4 = int.Parse(txtNota4.Text);

            lblPromedio.Text = objP.calculaPromedio().ToString("0.00");
            lblMasBaja.Text = objP.masBaja().ToString();
            lblCondicion.Text = objP.asignaCondicion();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAlumno.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();

            lblPromedio.Text = "";
            lblMasBaja.Text = "";
            lblCondicion.Text = "";

            txtAlumno.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
