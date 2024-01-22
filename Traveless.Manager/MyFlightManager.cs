using System;
using System.Collections.Generic;
using System.IO;
using Traveless.Manager.Abstract;
using Traveless.Manager.Entities;

namespace Traveless.Manager
{
    /// <summary>
    /// Manages flights
    /// </summary>
    public class MyFlightManager : FlightManager
    {
        /// <summary>
        /// Path to flights.csv file
        /// </summary>
        public static readonly string FLIGHTS_FILE = "Data/flights.csv";

        /// <summary>
        /// Populates list with Flight instances from file
        /// </summary>
        protected override void LoadFlights()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FLIGHTS_FILE);

            // Open StreamReader at path
            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                // Loop through each line in the file
                while ((line = reader.ReadLine()) != null)
                {
                    //  Transform line into cells using a comma (,)
                    string[] cells = line.Split(',');

                    //  Check number of cells is not 7
                    if (cells.Length != 7)
                    {
                        //Do next iteration of loop if incorrect number of cells
                        continue;
                    }
                    //  Create Flight instance from cells
                    Flight flight = new Flight(
                       cells[0],
                       cells[1],
                       cells[2],
                       cells[3],
                       cells[4],
                       int.Parse(cells[5]),
                       decimal.Parse(cells[6])
                       );

                    //  Add Flight instance to _flights list
                    _flights.Add(flight);
                }
            }
        }

        /// <summary>
        /// Finds flight with code
        /// </summary>
        /// <param name="code">Flight code argument</param>
        /// <returns>Flight instance (or null if not found)</returns>
        public override Flight? FindFlightByCode(string code)
        {
            // Loop through each flight in Flights
            foreach (Flight flight in _flights)
            {
                //  Check current flight code exactly matches code argument
                if (flight.Code == code)
                {
                    //Return current Flight instance to calling method
                    return flight;
                }
            }

            // Return null to calling method if no flight with code is found.
            return null;
        }
    }
}