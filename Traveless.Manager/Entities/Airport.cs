namespace Traveless.Manager.Entities
{
    /// <summary>
    /// Represents an Airport
    /// </summary>
    public class Airport
    {
        /// <summary>
        /// Three letter airport code
        /// All Canadian airport codes start with Y
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Full name of airport
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Constructors Airport instance
        /// </summary>
        /// <param name="code">Airport code</param>
        /// <param name="name">Name of airport</param>
        public Airport(string code, string name)
        {
            Code = code;
            Name = name;
        }

        /// <summary>
        /// Used to determine what Airport should be when cast to a string
        /// </summary>
        /// <returns>Human readable form of airport</returns>
        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Code);
        }
    }
}
