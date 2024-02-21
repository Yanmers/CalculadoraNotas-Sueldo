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
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
        }
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculoNomina_Click(object sender, EventArgs e)
        {
            

           
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            try
            {
                double SalarioHoras, SueldoBase, HorasTrabajadas , HorasExtras, DescAfp,DescArs, DescIrs, SueldoCobra;
                
                claNomina Uapa = new claNomina();

                SalarioHoras = int.Parse(txtSalarioHoras.Text);
                HorasTrabajadas = int.Parse(txtHorasTrabajadas.Text);
                HorasExtras = int.Parse(txtHorasExtras.Text);

                SueldoBase = (SalarioHoras * HorasTrabajadas) + (2 * (SalarioHoras * HorasExtras));
                txtSalarioBase.Text = SueldoBase.ToString();
                DescArs = SueldoBase * Uapa.DescArs();
                DescAfp = SueldoBase * Uapa.DescAfp();
                DescIrs = Uapa.DescIrs(SueldoBase);

                SueldoCobra = SueldoBase - DescArs - DescAfp;

                
                txtDescArs.Text = DescArs.ToString();
                txtDescAfp.Text = DescAfp.ToString();
                txtSalarioNeto.Text = SueldoCobra.ToString();
                txtDescIsr.Text = DescIrs.ToString();
                

            }
            catch (Exception error)
            {

                MessageBox.Show("Error" + error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach(Control datos in this.groupBox1.Controls)
            {
                if(datos is TextBox)
                {
                    datos.Text = string.Empty;
                }
            }

            foreach (Control datos in this.groupBox2.Controls)
            {
                if (datos is TextBox)
                {
                    datos.Text = string.Empty;
                }
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
