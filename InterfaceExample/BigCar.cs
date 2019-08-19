using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    class BigCar : ICar
    {
        double ICar.Speed => 120; //km hr
        double ICar.Weight => 5000;
        double ICar.GasolinUsing => 0.7;
        double ICar.WeightMove => 1500;
        string ICar.TypeOfCar => "Грузовая";
        double ICar.HowmuchGasolinWeightCanHold => 150;
        void ICar.Move(ICar car)
        {
           Console.WriteLine(car.TypeOfCar  + " проедет  "  + car.HowmuchGasolinWeightCanHold / car.GasolinUsing + " KM "  + " может переместить " + car.WeightMove +  " при этом вес машины " + car.Weight);
        }
    }
}
