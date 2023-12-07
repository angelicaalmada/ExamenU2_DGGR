using ExamenU2_DGGR.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenU2_DGGR.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vcalorias : ContentPage
    {
        public Vcalorias()
        {
            InitializeComponent();
            BindingContext = new VMcalorias(Navigation);
        }
    }
}