using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int PruebaFinal, ActividadesPracticas, ProyectoFinal, ActitudesValores, ParticipacionOralEscrita, Nota;

            claUapa Uapa = new claUapa();
            PruebaFinal = int.Parse(txtPruebaFinal.Text);
            ActividadesPracticas = int.Parse(txtActividadesPracticas.Text);
            ProyectoFinal = int.Parse(txtProyectoFinal.Text);
            ActitudesValores = int.Parse(txtActitudesValores.Text);
            ParticipacionOralEscrita = int.Parse(txtParticipacionOralEscrita.Text);

            Nota = Uapa.NotaFinal(PruebaFinal, ActividadesPracticas, ProyectoFinal, ActitudesValores, ParticipacionOralEscrita);
            txtNota.Text =Nota.ToString();
            txtResultado.Text =Uapa.Resultado(Nota);
            txtLiteral.Text = Uapa.Literal(Nota);
        }
    }
}
