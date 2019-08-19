using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    class LightWhgtCar : ICar
    {
        double ICar.Speed => 200; //km hr
        double ICar.Weight => 2000;
        double ICar.GasolinUsing => 0.4;
        double ICar.WeightMove => 500;
        string ICar.TypeOfCar => "Легковая";
        double ICar.HowmuchGasolinWeightCanHold => 70;
        void ICar.Move(ICar car)
        {
           Console.WriteLine(car.TypeOfCar  + " проедет  "  + car.HowmuchGasolinWeightCanHold / car.GasolinUsing + " KM "  + " может переместить " + car.WeightMove +  " при этом вес машины " + car.Weight);
        }
    }
}
