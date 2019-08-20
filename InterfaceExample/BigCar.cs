using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    public class  BigCar : ICar
    {
       public double Speed => 120; //km hr
       public double Weight => 5000;
       public double GasolinUsing => 0.7;
       public double WeightMove => 1500;
       public string TypeOfCar => "Грузовая";
       public double HowmuchGasolinWeightCanHold => 150;
       public  void Move()
        {
           Console.WriteLine(TypeOfCar + " проедет  "  + HowmuchGasolinWeightCanHold / GasolinUsing + " KM "  + " может переместить " + WeightMove +  " при этом вес машины " + Weight);
        }
    }
}
