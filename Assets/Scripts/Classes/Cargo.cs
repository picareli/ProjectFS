using System;

namespace ProjectFS
{
    /// <summary> Data of an specific Cargo that can be transported from an Airport. </summary>
    [Serializable]
    public class Cargo
    {
        #region PROPERTIES

        /// <summary> The CargoType of this Cargo. </summary>
        public CargoTypes Type { get; private set; }
        /// <summary> Minimum weight of this Cargo, in kilos, that can be transported in an unique Flight. </summary>
        public int MinWeight { get; private set; }
        /// <summary> Current ammount of this Cargo to be transported. </summary>
        public int Weight { get; private set; }
        /// <summary> Base ammount paid on successfull flight, per kilo. </summary>
        public int BaseReward { get; private set; }

        #endregion
    }
}