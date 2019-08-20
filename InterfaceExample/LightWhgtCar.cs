using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    public class LightWhgtCar : ICar
    {
        public double Speed => 200; //km hr
        public  double Weight => 2000;
        public  double GasolinUsing => 0.4;
        public  double WeightMove => 500;
        public  string TypeOfCar => "Легковая";
        public  double HowmuchGasolinWeightCanHold => 70;
        public  void Move()
        {
           Console.WriteLine(TypeOfCar  + " проедет  "  + HowmuchGasolinWeightCanHold / GasolinUsing + " KM "  + " может переместить " + WeightMove +  " при этом вес машины " + Weight);
        }
    }
}
