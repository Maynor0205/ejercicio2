using ejercicio2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ejercicio2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnprocesar_Clicked(object sender, EventArgs e)
        {
            var emple = new Empleado
            {
                id = 1,
                nombres = txtnombre.Text,
                apellidos = txtapellido.Text,
                edad = int.Parse(txtedad.Text),
                correo = txtacorreo.Text,
                foto = null
            };

            // Esto es para llamar una segunda pagina y pasarle parametro a una segunda pantalla
            var secondpage = new PageResultado();
            secondpage.BindingContext = emple; // Paso de parametros a la pantalla
            Navigation.PushAsync(secondpage);
        }
    }
}
