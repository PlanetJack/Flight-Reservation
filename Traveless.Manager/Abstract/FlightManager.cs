using System;
using System.Collections.Generic;
using System.IO;
using Traveless.Manager.Entities;

namespace Traveless.Manager.Abstract
{
    /// <summary>
    /// Manages flights
    /// DO NOT MODIFY THIS FILE
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Feb 12, 2023</remarks>
    public abstract class FlightManager
    {
        /// <summary>
        /// Holds list of Flight instances.
        /// </summary>
        protected readonly List<Flight> _flights;

        /// <summary>
        /// Gets new list of Flight instances
        /// </summary>
        /// <remarks>This is a read-only list. You cannot add/remove items.</remarks>
        public IList<Flight> Flights
        {
            get => new List<Flight>(_flights).AsReadOnly();
        }

        /// <summary>
        /// Constructs flight manager
        /// </summary>
        public FlightManager()
        {
            _flights = new List<Flight>();

            LoadFlights();
        }

        /// <summary>
        /// Finds flight with code
        /// </summary>
        /// <param name="code">Flight code</param>
        /// <returns>Flight instance (or null if not found)</returns>
        public abstract Flight? FindFlightByCode(string code);

        /// <summary>
        /// Populates list with Flight instances from file
        /// </summary>
        protected abstract void LoadFlights();
    }
}
