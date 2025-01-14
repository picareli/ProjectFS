using System;

namespace ProjectFS
{
    /// <summary> Data of a specific Aircraft that can be used. </summary>
    [Serializable]
    public class Aircraft
    {
        #region PROPERTIES

        /// <summary> The AircraftModel information of this Aircraft. </summary>
        public AircraftModel Model { get; private set; }
        /// <summary> Alphanumeric combination that uniquely identifies this Aircraft. </summary>
        public string Registration { get; private set; }
        /// <summary> The age in hours of this Aircraft. </summary>
        public float TotalHours { get; private set; }
        /// <summary> Current percentage of damange to the tires of this Aircraft. </summary>
        public int TireDamage { get; private set; }
        /// <summary> Current ammount of fuel, in kilos, loaded to this Aircraft. </summary>
        public int TotalFuel { get; private set; }
        /// <summary> Total hours left before an inspection is required. </summary>
        public float NextInspection { get; private set; }
        /// <summary> Can this Aircraft be flown in its current state? </summary>
        public bool IsAirWorthy { get; private set; } = true;
        /// <summary> Is this Aircraft currently selected to be flown in the next job? </summary>
        public bool IsSelected { get; private set; } = false;
        /// <summary> The Airport that this aircraft is currently in. </summary>
        public Airport Location { get; private set; }
        /// <summary> Current payload, in kilos, loaded into this Aircraft. </summary>
        public int Payload { get; private set; }

        #endregion
    }
}