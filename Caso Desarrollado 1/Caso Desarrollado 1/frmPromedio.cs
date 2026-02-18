using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjPromedioNotas
{
    public partial class frmPromedio : Form
    {
        public frmPromedio()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Objeto de la clase Promedio
            Promedio objP = new Promedio();

            // Enviando los valores a la clase
            objP.alumno = txtAlumno.Text;
            objP.nota1 = int.Parse(txtNota1.Text);
            objP.nota2 = int.Parse(txtNota2.Text);
            objP.nota3 = int.Parse(txtNota3.Text);
            objP.nota4 = int.Parse(txtNota4.Text);

            // Imprimiendo los valores
            lblPromedio.Text = objP.calculaPromedio().ToString("0.00");
            lblBaja.Text = objP.masBaja().ToString("0.00");
            lblCondicion.Text = objP.asignaCondicion();
        }
    }
}