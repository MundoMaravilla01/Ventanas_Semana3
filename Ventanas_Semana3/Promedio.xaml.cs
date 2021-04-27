using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ventanas_Semana3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Promedio : ContentPage
    {
        public Promedio()
        {
            InitializeComponent();
        }

        private void bntSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Convert.ToDouble(txtExamen1.Text);
                double valor2 = Convert.ToDouble(txtSeguimiento1.Text);

                double suma = valor1*(0.3) + valor1*(0.2);
                txtNParcial1.Text = suma.ToString();            }
            catch (Exception ex) 
            {
                DisplayAlert("Alerta", ex.Message, "gracias");
            }
        }

        private void bntSumar2_Clicked(object sender, EventArgs e)
        {
            try
            {
                double valor3 = Convert.ToDouble(txtExamen2.Text);
                double valor4 = Convert.ToDouble(txtSeguimiento2.Text);

                double suma2 = valor3 * (0.3) + valor4 * (0.2);
                txtNParcial2.Text = suma2.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "gracias");
            }
        }

       

        private void bntSumar3_Clicked(object sender, EventArgs e)
        {

            try
            {
                double valor5 = Convert.ToDouble(txtNParcial1.Text);
                double valor6 = Convert.ToDouble(txtNParcial2.Text);

                double suma3 = valor5 + valor6;
                txtFinal.Text = suma3.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "gracias");
            }
        }
    }
}