using System;
using System.Collections.Generic;

namespace ProjectFS
{
    /// <summary> Defines the data of an specific Flight. </summary>
    [Serializable]
    public class Flight
    {
        #region  PROPERTIES

        /// <summary> Starting Airport for this Flight. </summary>
        public Airport Origin { get; private set; }
        /// <smumary> Destination Airport for this Flight. </summary>
        public Airport Destination { get; private set; }
        /// <summary> The distance, in km, between the Origin and the Destination. </summary>
        public int Distance { get; private set; }
        /// <summary> List of Passengers being transported in this Flight. </summary>
        public List<Passenger> Passengers { get; private set; }
        /// <summary> List of Cargos being transported in this Flight. </summary>
        public List<Cargo> Cargos { get; private set; }
        /// <summary> Payload weight, in kilos, of this Flight. </summary>
        public int Payload { get; private set; }
        /// <summary> Ammount paid for completing this Flight. </summary>
        public int Reward { get; private set; }

        /// <summary> True when this Flight is completed. </summary>
        public bool IsComplete { get; private set; } = false;
        /// <summary> The date and time of completion of this Flight. </summary>
        public DateTime Date { get; private set; }

        #endregion
    }
}