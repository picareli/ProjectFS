using System;

namespace ProjectFS
{
    /// <summary> Defines a Passenger that can be transported in a Flight. </summary>
    [Serializable]
    public class Passenger
    {
        /// <summary> Wether this Passenger is a child, adult male or adult female. </summary>
        public PassengerTypes Type { get; private set; }
        /// <summary> The weight, in kilos, of this Passenger. </summary>
        public int Weight { get; private set; }
        /// <summary> The weight of the baggage, in kilos, this Passenger is carrying. </summary>
        public int BaggageWeight { get; private set; }
    }
}