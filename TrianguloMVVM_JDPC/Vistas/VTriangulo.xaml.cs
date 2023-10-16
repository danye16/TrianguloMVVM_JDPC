using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrianguloMVVM_JDPC.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrianguloMVVM_JDPC.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VTriangulo : ContentPage
    {
        public VTriangulo()
        {
            InitializeComponent();
            BindingContext = new VMTriangulo(Navigation);
        }
    }
}