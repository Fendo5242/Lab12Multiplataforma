using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoMVVMB.ViewModels
{
    public class SueldoViewModel: ViewModelBase
    {
        double sueldo;
        public double Sueldo
        {
            get { return sueldo; }
            set { 
                if(sueldo != value)
                {
                    sueldo= value;
                    OnPropertyChanged();
                } }
        }

        double gratificacion;
        public double Gratificacion
        {
            get { return gratificacion; }
            set
            {
                if (gratificacion != value)
                {
                    gratificacion = value;
                    OnPropertyChanged();
                }
            }
        }

        double sueldoneto;
        public double SueldoNeto
        {
            get { return sueldoneto; }
            set
            {
                if (sueldoneto != value)
                {
                    sueldoneto = value;
                    OnPropertyChanged();
                }
            }
        }

        double descuento;
        public double Descuento
        {
            get { return descuento; }
            set
            {
                if (descuento != value)
                {
                    descuento = value;
                    OnPropertyChanged();
                }
            }
        }

        double sueldodescuento;
        public double SueldoDescuento
        {
            get { return sueldodescuento; }
            set
            {
                if (sueldodescuento != value)
                {
                    sueldodescuento = value;
                    OnPropertyChanged();
                }
            }
        }

        double impuesto;
        public double Impuesto
        {
            get { return impuesto; }
            set
            {
                if (impuesto != value)
                {
                    impuesto = value;
                    OnPropertyChanged();
                }
            }
        }
        public ICommand CalcularSueldoNeto { get; set; }
        public ICommand CalcularDescuento { get; set; }
        public ICommand CalcularImpuesto { get; set; }
        public SueldoViewModel()
        {
            CalcularSueldoNeto = new Command(() => {
                SueldoNeto = Sueldo + Gratificacion;
            });
            CalcularDescuento = new Command(() =>
            {
                SueldoDescuento = SueldoNeto - Descuento;
            });
            CalcularImpuesto = new Command(() =>
            {
                Impuesto = SueldoNeto * 0.18;

            });
        }
    }
}
