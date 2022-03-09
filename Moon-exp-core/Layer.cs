using System;
using System.Collections.Generic;
using System.Text;

namespace moon_exp_core
{
    class Layer
    {

        public List<Lens> lenses;
        private Dictionary<int, int> measurements;

        public bool ThinnedCompletely_6 => false;
        public int PossibleLensesCount_8 => 0;
        public int MaxThickness_5 => 0;
        public int MeasurementsCount => 0;

        public Layer(string measurements)
        {

        }
    }
}
