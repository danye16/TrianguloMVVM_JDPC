using System;
using TrianguloMVVM_JDPC.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrianguloMVVM_JDPC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VTriangulo();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
