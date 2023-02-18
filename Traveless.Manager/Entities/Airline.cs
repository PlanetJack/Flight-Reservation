namespace Traveless.Manager.Entities
{
    /// <summary>
    /// Represents an airline
    /// </summary>
    public class Airline
    {
        /// <summary>
        /// Two letter code for airline.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Full name of airline.
        /// </summary>
        public string Name { get; set; }

        public Airline(string code, string name)
        {
            Code = code;
            Name = name;
        }

        /// <summary>
        /// Used when Airline is cast to a string.
        /// </summary>
        /// <returns>Human readable airline</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
