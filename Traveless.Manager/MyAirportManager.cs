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
            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                // Loop through each line in the file
                while ((line = reader.ReadLine()) != null)
                {
                    //  Transform line into cells using a comma (,)
                    string[] cells = line.Split(',');

                    //  Check number of cells is not 2
                    if (cells.Length != 2)
                    {
                        //Do next iteration of loop if incorrect number of cells
                        continue;
                    }

                    //  Create Airport instance from cells
                    Airport airport = new Airport(cells[0], cells[1]);

                    //  Add Airport instance to _airports list
                    _airports.Add(airport);

                    line = reader.ReadLine();
                }
            }
            // Close StreamReader
        }
    }
}

