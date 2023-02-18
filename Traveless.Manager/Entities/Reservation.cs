namespace Traveless.Manager.Entities
{
    /// <summary>
    /// Represents a Reservation
    /// </summary>
    public class Reservation : IEquatable<Reservation>
    {
        /// <summary>
        /// Reservation code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Flight reservation is for
        /// </summary>
        public Flight Flight { get; set; }

        /// <summary>
        /// Name on reservation
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Persons citizenship
        /// </summary>
        public string Citizenship { get; set; }

        /// <summary>
        /// Whether reservation is active or not
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Zero arg constructor for Reservation
        /// </summary>
        public Reservation()
        {

        }

        /// <summary>
        /// Non-default constructor for Reservation
        /// </summary>
        /// <param name="code"></param>
        /// <param name="flight"></param>
        /// <param name="name"></param>
        /// <param name="citizenship"></param>
        /// <param name="isActive"></param>
        public Reservation(string code, Flight flight, string name, string citizenship, bool isActive)
        {
            Code = code;
            Flight = flight;
            Name = name;
            Citizenship = citizenship;
            IsActive = isActive;
        }


        /// <summary>
        /// Checks if this Reservation is the same as another Reservation
        /// </summary>
        /// <param name="other">Other reservation</param>
        /// <returns>True if they're equal</returns>
        public bool Equals(Reservation? other)
        {
            if (other == null) return false;
            if (this == other) return true;

            return Code == other.Code;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Reservation);
        }

        /// <summary>
        /// Called when Reservation is cast to a string
        /// </summary>
        /// <returns>String representation of Reservation instance.</returns>
        public override string ToString()
        {
            return Code;
        }

        /// <summary>
        /// Generates reservation code for Flight
        /// </summary>
        /// <param name="flight">Flight instance</param>
        /// <returns>Reservation code</returns>
        public static string GenerateReservationCode(Flight flight)
        {
            Random rand = new Random();

            char letter;

            // Set letter to D (if domestic) or I (if international)
            if (flight.IsDomestic)
            {
                letter = 'D';
            }
            else
            {
                letter = 'I';
            }

            // Use Random instance to generate (somewhat) random number.
            int num = rand.Next(1000, 9999);

            return string.Format("{0}{1}", letter, num);
        }
    }
}
