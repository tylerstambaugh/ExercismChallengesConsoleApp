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
        private int weight;
        public int Weight
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
        private double displayWeight;
        public double DisplayWeight
        {
            get { return Weight - TareAdjustment; }
        }

        // TODO: define the 'TareAdjustment' property
        public int TareAdjustment { get; set; } = 5;
    }

}
