using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TrianguloMVVM_JDPC.VistaModelo
{
    class VMTriangulo : BaseViewModel
    {
        #region VARIABLES
        string _Mensaje;
        double _Lado1;
        double _Lado2;
        double _Area;
        double _Base;
        double _Altura;
        #endregion
        #region CONSTRUCTOR
        public VMTriangulo(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Objetos
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        public double Lado1
        {
            get { return _Lado1; }
            set { SetValue(ref _Lado1, value); }
        }
        public double Lado2
        {
            get { return _Lado2; }
            set { SetValue(ref _Lado2, value); }
        }
        public double Altura
        {
            get { return _Altura; }
            set { SetValue(ref _Altura, value); }
        }
        public double Area
        {
            get { return _Area; }
            set { SetValue(ref _Area, value); }
        }
        public double Base
        {
            get { return _Base; }
            set { SetValue(ref _Base, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void CalcularArea(double a,  double b)
        {
            Area = (Altura * Base) / 2;
        }

        public async void BTNCalcularArea()
        {
            CalcularArea( Base, Altura);
            //Declarar variable y asignarle valor

            //Realizar el calculo



            //enviar resultado

            string validarTriangulo = "";
            if ((Lado1 + Lado2) < Base)
            {
                validarTriangulo = "No Es un triangulo";
            }
            else if ((Base + Lado1) < Lado2)
            {
                validarTriangulo = "No Es un triangulo";
            }

            else if ((Base + Lado2) < Lado1)
            {
                validarTriangulo = "No Es un triangulo";
            }
            else
            {
                validarTriangulo = "es un triangulo";
                string resultado = "";
                if (Base == Lado1 && Base == Lado2)

                {
                    resultado = "Su triangulo es Equilatero";
                 //   imgEquilatero.IsVisible = true;
                  //  imgEscaleno.IsVisible = false;
                  //  imgIsoceles.IsVisible = false;
                }
                else if (Base != Lado1 && Lado1 != Lado2)

                {
                    resultado = "Su triangulo es Escaleno";
                 //   imgEscaleno.IsVisible = true;
                 //   imgIsoceles.IsVisible = false;
                  //  imgEquilatero.IsVisible = false;
                }
                else

                {
                    resultado = "Su triangulo es Isoceles";
                  //  imgIsoceles.IsVisible = true;
                  //  imgEquilatero.IsVisible = false;
                  //  imgEscaleno.IsVisible = false;
                }


             await   DisplayAlert("Resultado ", resultado, "Quitar");
            }
          await  DisplayAlert("Resultado ", validarTriangulo, "Quitar");
        }
        #endregion
        #region COMMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand CalcularAreaCommand => new Command(BTNCalcularArea);
        #endregion
    }
}
