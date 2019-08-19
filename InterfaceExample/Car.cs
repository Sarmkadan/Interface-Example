using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    interface ICar
    {
        double Speed { get; }
        double Weight { get; }
        double GasolinUsing { get; } 
        double WeightMove { get; }
        string TypeOfCar { get; }
        double HowmuchGasolinWeightCanHold { get; }
        void Move(ICar car);
    }
}
