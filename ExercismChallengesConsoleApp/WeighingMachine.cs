using System;

class WeighingMachine
{
    public WeighingMachine(int precision)
    {
        Precision = precision;
    }
    // TODO: define the 'Precision' propert
    public int Precision { get; }

    // TODO: define the 'Weight' property
    private double weight;
    public double Weight
    {
        get { return weight; }
        set
        {
            if (value > 0)
            {
                weight = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }

    // TODO: define the 'DisplayWeight' property
    private string displayWeight;
    public string DisplayWeight
    {
        get
        {
            return (weight - TareAdjustment).ToString($"F{Precision}") + " kg";
        }
    }

    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment { get; set; } = 5.0;
}