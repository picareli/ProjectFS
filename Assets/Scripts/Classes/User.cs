using System;
using System.Collections.Generic;

namespace ProjectFS
{
    /// <summary> Data that defines an User. </summary>
    [Serializable]
    public class User
    {
        #region PROPERTIES

        /// <summary> The Name of this User. </summary>
        public string Name { get; private set; }
        /// <summary> Total hours flown by this User. </summary>
        public float TotalHours { get; private set; }
        /// <summary> Total weight, in kilos, transported by this User. </summary>
        public float TotalCargo { get; private set; }
        /// <summary> Current balance available for transactions. </summary>
        public float Balance { get; private set; }
        /// <summary> History of flights completed by this User. </summary>
        public List<Flight> LogBook { get; private set; }
        /// <summary> List of Aircraft owned by this User. </summary>
        public List<Aircraft> Fleet { get; private set; }
        /// <summary> The Aircraft that is currently selected by this User. </summary>
        public Aircraft SelectedAircraft { get; private set; }

        #endregion
    }
}