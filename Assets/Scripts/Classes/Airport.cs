using System;
using System.Collections.Generic;

namespace ProjectFS
{
    /// <summary> Defines an specific Airport. </summary>
    [Serializable]
    public class Airport
    {
        #region PROPERTIES

        /// <summary> An unique four letter code that identifies this Airport. </summary>
        public string Identifier { get; private set; }
        /// <summary> The country where this Airport is located. </summary>
        public string Country { get; private set; }
        /// <summary> The list of each of this Airport's Runways. </summary>
        public List<Runway> Runways { get; private set; }

        /// <summary> Base cost to fly into this Airport. </summary>
        public int Fees { get; private set; }

        /// <summary> The list of Cargos available for transport from this Airport. </summary>
        public List<Cargo> AvailableCargo { get; private set; }
        /// <summary> The list of Cargos needed at this Airport. </summary>
        public List<Cargo> NeededCargo { get; private set; }


        #endregion
    }
}