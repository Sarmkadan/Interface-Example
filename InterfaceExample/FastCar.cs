using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    public class FastCar : ICar
    {
        public double Speed => 600; //km hr
        public double Weight => 1200;
        public double GasolinUsing => 0.8;
        public double WeightMove => 100;
        public  string TypeOfCar => "Гоночная";
        public  double HowmuchGasolinWeightCanHold => 40;
        public  void Move()
        {
           Console.WriteLine(TypeOfCar  + " проедет  "  + HowmuchGasolinWeightCanHold / GasolinUsing + " KM "  
                             + " может переместить " + WeightMove +  " при этом вес машины " + Weight);
        }
    }
}
