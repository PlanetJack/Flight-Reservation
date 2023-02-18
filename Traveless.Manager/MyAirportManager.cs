using Traveless.Manager.Abstract;
using Traveless.Manager.Entities;

namespace Traveless.Manager
{
    /// <summary>
    /// Manages airports
    /// </summary>
    public class MyAirportManager : AirportManager
    {
        /// <summary>
        /// Path to airports.csv file
        /// </summary>
        public static readonly string AIRPORTS_FILE = "Data/airports.csv";

        /// <summary>
        /// Populates list with Airport instances from .csv file.
        /// </summary>
        protected override void LoadAirports()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AIRPORTS_FILE);

            // Open StreamReader at path

            // Loop through each line in the file
            //  Transform line into cells using a comma (,)

            //  Check number of cells is not 2
            //      Do next iteration of loop if incorrect number of cells

            //  Create Airport instance from cells

            //  Add Airport instance to _airports list

            // Close StreamReader
        }
    }
}
