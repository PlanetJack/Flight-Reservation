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

            // Loop through each line in the file
            //  Transform line into cells using a comma (,)

            //  Check number of cells is not 7
            //      Do next iteration of loop if incorrect number of cells

            //  Create Flight instance from cells
            //  Add Flight instance to _flights list

        }

        /// <summary>
        /// Finds flight with code
        /// </summary>
        /// <param name="code">Flight code argument</param>
        /// <returns>Flight instance (or null if not found)</returns>
        public override Flight? FindFlightByCode(string code)
        {
            // Loop through each flight in Flights
            //  Check current flight code exactly matches code argument
            //      Return current Flight instance to calling method

            // Return null to calling method if no flight with code is found.
            return null;
        }
    }
}
