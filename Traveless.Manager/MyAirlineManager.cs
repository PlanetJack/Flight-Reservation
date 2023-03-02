using System;
using System.Collections.Generic;
using System.IO;
using Traveless.Manager.Abstract;
using Traveless.Manager.Entities;

namespace Traveless.Manager
{
    /// <summary>
    /// Manages airlines
    /// </summary>
    public class MyAirlineManager : AirlineManager
    {
        /// <summary>
        /// Path to airlines.csv file
        /// </summary>
        public static readonly string AIRLINES_FILE = "Data/airlines.csv";

        /// <summary>
        /// Populate list with Airline instances from CSV files
        /// </summary>
        protected override void LoadAirlines()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AIRLINES_FILE);

            // Open StreamReader at path
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                // Loop through each line in the file
                while ((line = reader.ReadLine()) != null)
                {
                    //  Transform line into cells using a comma (,)
                    string[] cell = line.Split(',');
                    //  Check number of cells is not 2
                    if (cell.Length != 2)
                    {
                        //      Do next iteration of loop if incorrect number of cells
                        continue;
                    }
                    //  Create Airline instance from cells
                    Airline airline = new Airline(cell[0], cell[1]);

                    //  Add Airline instance to _airlines list
                    _airlines.Add(airline);

                    line = reader.ReadLine();
                }
            }
            // Close StreamReader
        }
    }
}