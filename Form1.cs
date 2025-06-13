using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMC
{
    public partial class Form1 : Form
    {
        clsCalcularIMC IMC;
        public Form1()
        {
            IMC = new clsCalcularIMC();
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //Incio mis valores a mis propiedades
                IMC.Altura = float.Parse(txtAltura.Text);
                IMC.Peso = float.Parse(txtPeso.Text);
                IMC.NoPasos = int.Parse(txtNoPasos.Text);
                IMC.TamañoZancada = float.Parse(txtTamZancada.Text);

                //Lamada a las funciones
                IMC.CalcularKmCaminados();
                //Salida
                txtIMC.Text = IMC.CalcIMC().ToString();
                txtEstadoSalud.Text = IMC.CalcEstadoSalud().ToString();
                txtPlanAccion.Text = IMC.DefinirPlanAccion().ToString();
            }
            catch (Exception ex)
            { 
                MessageBox.Show("           Ningun dato puede ser nulo" + "\r\n" + "Verifique que todos los campos esten llenos");
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo datos numericos");
                e.Handled = true;
            }
        }
        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '.')
            {
                
                if (txtAltura.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo datos numericos");
                e.Handled = true; 
            }
        }

        private void txtNoPasos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo datos numericos");
                e.Handled = true;
            }
        }

        private void txtTamZancada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {

                if (txtTamZancada.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo datos numericos");
                e.Handled = true;
            }
        }

        
    }
}
