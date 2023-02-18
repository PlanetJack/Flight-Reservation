using System;
using System.Collections.Generic;
using System.IO;
using Traveless.Manager.Entities;

namespace Traveless.Manager.Abstract
{
    /// <summary>
    /// Manages airlines
    /// DO NOT MODIFY THIS FILE
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Feb 12, 2023</remarks>
    public abstract class AirlineManager
    {
        /// <summary>
        /// Holds list of Airline instances
        /// </summary>
        protected readonly List<Airline> _airlines;

        /// <summary>
        /// Gets a list of Airline instances
        /// </summary>
        /// <remarks>This is a read-only list. You cannot add/remove items.</remarks>
        public IList<Airline> Airlines
        {
            get => new List<Airline>(_airlines).AsReadOnly();
        }

        /// <summary>
        /// Constructors airline manager
        /// </summary>
        public AirlineManager()
        {
            _airlines = new List<Airline>();

            LoadAirlines();
        }

        /// <summary>
        /// Finds airline with code
        /// </summary>
        /// <param name="code">Code of airline</param>
        /// <returns>Airline instance or null if not found</returns>
        public Airline? FindAirline(string code)
        {
            foreach (var airline in _airlines)
            {
                if (airline.Code == code)
                    return airline;
            }

            return null;
        }

        /// <summary>
        /// Populate list with Airline instances from CSV files
        /// </summary>
        protected abstract void LoadAirlines();
    }
}
