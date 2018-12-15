using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppConverterBakingFinal
{
    /*
         for a class to be able to bind, need to implement the
         INotifyPropertyChanged interface
         register interest
         */
    public class dataBindingClass : INotifyPropertyChanged
    {
        
        //implement the Property changed event
        public event PropertyChangedEventHandler PropertyChanged;

        //private variables
        private double ovenConv;

        //properties
        public double OvenConv
        {
            get { return ovenConv; }    // x = myAdder.Arg1
            set
            {
                ovenConv = value;   // myAdder.Arg1 = x;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this,
                        new PropertyChangedEventArgs("AnswerValue"));
                    PropertyChanged(this,
                        new PropertyChangedEventArgs("OvenConv"));
                }
            }
        }
        
        public double AnswerValue
        {
            get
            {
                return ovenConv;
            }
        }

    }
}
