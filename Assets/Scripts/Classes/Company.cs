using System;

namespace ProjectFS
{
    /// <summary> Data that defines a Company. </summary>
    [Serializable]
    public class Company
    {
        /// <summary> Unique code that identifies this Company. </summary>
        public string Identifier { get; private set; }
        /// <summary> Complete name of this Company. </summary>
        public string Name { get; private set; }
    }
}