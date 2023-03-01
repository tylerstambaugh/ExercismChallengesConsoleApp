//https://exercism.org/tracks/csharp/exercises/weighing-machine/edit

namespace ExercismChallengesConsoleApp
{
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
                string stringWeight = (Weight - TareAdjustment).ToString();
                return $"{stringWeight.Substring(0, stringWeight.IndexOf('.') + Precision + 1)} kg";             
            }
        }

        // TODO: define the 'TareAdjustment' property
        public double TareAdjustment { get; set; } = 5.000;
    }


}
