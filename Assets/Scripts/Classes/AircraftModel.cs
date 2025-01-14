using System;

namespace ProjectFS
{
    /// <summary> Collection of data that describes an especific type of Aircraft. </summary>
    [Serializable]
    public class AircraftModel
    {
        #region PROPERTIES

        /// <summary> A four letter code that identifies this type of Aircraft. </summary>
        public string ICAO { get; private set; }
        /// <summary> The complete name of this model of Aircraft. </summary>
        public string Model { get; private set; }
        /// <summary> Descriptor class of this type of Aircraft. </summary>
        public Descriptors Description { get; private set; }
        /// <summary> The type of engine used by this Aircraft. </summary>
        public EngineTypes EngineType { get; private set; }
        /// <summary> Total number of engines that this plane has. </summary>
        public int EngineNumber { get; private set; }
        /// <summary> Type of fuel used by this Aircraft. </summary>
        public FuelTypes FuelType { get; private set; }
        /// <summary> The weight category this Aircraft belongs to. </summary>
        public WeightCategories WTC { get; private set; }
        /// <summary> The aproach speed category this model of Aircraft belongs to. </summary>
        public Categories Category { get; private set; }
        /// <summary> Total price cost for a brand new Aircraft of this model. </summary>
        public int Price { get; private set; }

        #endregion

        #region PUBLIC METHODS

        #endregion

        #region PRIVATE METHODS

        #endregion
    }
}