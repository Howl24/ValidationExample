using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfApp2
{
    class ViewModel: IDataErrorInfo
    {
        public ViewModel()
        {
        }

        //Tienen q agregar estas propiedades ( Con el nombre de sus campos ps)        
        //Luego en el xaml, en los TextBoxes, en la parte q dice Binding ponen el nombre de la propiedad)
        //Y ya en el boton le ponen en Conditions ElementName el nombre de los TextBox q necesita para desactivarse
       
        public string ValidateInputText
        {
            get;
            set;
        }
               
        public int number = -1 ;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string this[string columnName]
        {
            get
            {
                //Aca le ponen las validaciones q tengan y devuelven el mensaje q quieren
                // q se muestre cuando no cumple
                if ("ValidateInputText" == columnName)
                {
                    if (String.IsNullOrEmpty(ValidateInputText))
                    {
                        return "Ingrese un texto";
                    }
                }
                else if ("Number" == columnName)
                {
                    if (Number < 0)
                    {
                        return "El numero debe ser >= a 0";
                    }
                }
                return "";
            }
        }

        public string Error
        {
            //Esto es por las huevas
            get { throw new NotImplementedException(); }
        }

    }
}
