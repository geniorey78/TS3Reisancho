using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TS3Reisancho
{ 
public partial class MainPage : ContentPage
{
    public static String NombreUsuario = "estudiante2021";
    public MainPage()
    {
        InitializeComponent();
    }

    private async void btnAbrir_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUser.Text;
        string clave = txtPass.Text;
        if ((usuario == "estudiante2021") && (clave == "uisrael2021"))

            await Navigation.PushAsync(new viewDos(usuario, clave));


        else
        {
            lblResultado.Text = "usario o contraseña incorrectos";
        }
    }
}

}
