using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    class FastCar : ICar
    {
        double ICar.Speed => 600; //km hr
        double ICar.Weight => 1200;
        double ICar.GasolinUsing => 0.8;
        double ICar.WeightMove => 100;
        string ICar.TypeOfCar => "Гоночная";
        double ICar.HowmuchGasolinWeightCanHold => 40;
        void ICar.Move(ICar car)
        {
           Console.WriteLine(car.TypeOfCar  + " проедет  "  + car.HowmuchGasolinWeightCanHold / car.GasolinUsing + " KM "  
                             + " может переместить " + car.WeightMove +  " при этом вес машины " + car.Weight);
        }
    }
}
