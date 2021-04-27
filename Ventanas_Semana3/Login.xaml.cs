using Microsoft.PowerBI.Api.Models;
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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //declaro variables
            String sUsuario = txtUsuario.Text;
            String sPassword = txtPassword.Text;

            if ((sUsuario == "estudiante2021") && (sPassword == "uisrael2021"))
            {
                Navigation.PushAsync(new Promedio());
            
            }
            else

            {
                lblResultado.Text = "Tu cuenta o contraseña no es correcta. Si no recuerdas la contraseña, restablécela.";

            }
        }
    }
}