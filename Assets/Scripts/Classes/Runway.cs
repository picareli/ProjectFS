using System;

namespace ProjectFS
{
    /// <summary> Describes a Runway where planes can land. </summary>
    [Serializable]
    public class Runway
    {
        #region PROPERTIES

        /// <summary> The Length, in feet, of this Runway. </summary>
        public int Length { get; private set; }
        /// <summary> Surface type of this Runway. </summary>
        public RunwayTypes Type { get; private set; }

        #endregion
    }
}