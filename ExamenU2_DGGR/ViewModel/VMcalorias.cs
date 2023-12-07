using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExamenU2_DGGR.ViewModel
{
    public class VMcalorias : BaseViewModel
    {
        #region VARIABLES
        double _Duracion;
        double _peso;
        double _calorias;
        string _mensaje;
        bool _mostrarcorrer;
        bool _mostrarcorrer2;
        bool _mostrarfelicidades;
        #endregion
        #region CONSTRUCTOR
        public VMcalorias(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public double Duracion
        {
            get { return _Duracion; }
            set { SetValue(ref _Duracion, value); }
        }
        public double Peso
        {
            get { return _peso; }
            set { SetValue(ref _peso, value); }
        }
        public double Calorias
        {
            get { return _calorias; }
            set { SetValue(ref _calorias, value); }
        }
        public string Mensaje
        {
            get { return _mensaje; }
            set { SetValue(ref _mensaje, value); }
        }
        public bool Mostrarcorrer
        {
            get { return _mostrarcorrer; }
            set { SetValue(ref _mostrarcorrer, value); }
        }
        public bool Mostrarcorrer2
        {
            get { return _mostrarcorrer2; }
            set { SetValue(ref _mostrarcorrer2, value); }
        }
        public bool Mostrarfelicidades
        {
            get { return _mostrarfelicidades; }
            set { SetValue(ref _mostrarfelicidades, value); }
        }

        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {
           
        }
        public void BtnCalcular()
        {
            calcularcalorias(_Duracion, _peso);

            if(Calorias < 250)
            {
                Mensaje = "Debe correr más tiempo y lograr superarse";
                Mostrarcorrer= true;
                Mostrarcorrer2= false;
                Mostrarfelicidades= false;
            }
            else if(Calorias >= 250 && Calorias <= 499)
            {
                Mensaje = "Va por buen camiono pero debe esforzarce un poco más";
                Mostrarcorrer = false;
                Mostrarcorrer2 = true;
                Mostrarfelicidades = false;
            }
            else if (Calorias > 499)
            {
                Mensaje = "Felicidades";
                Mostrarcorrer = false;
                Mostrarcorrer2 = false;
                Mostrarfelicidades = true;
            }
        }
        public void calcularcalorias(double p, double d)
        {
           Calorias  = d * 10 * p / 200;
        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand BtnCalcularcomand => new Command(BtnCalcular);
        #endregion
    }
}
