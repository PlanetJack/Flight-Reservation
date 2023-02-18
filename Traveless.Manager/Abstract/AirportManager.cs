using Traveless.Manager.Entities;

namespace Traveless.Manager.Abstract
{
    /// <summary>
    /// Manages airports
    /// DO NOT MODIFY THIS FILE
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Feb 12, 2023</remarks>
    public abstract class AirportManager
    {
        /// <summary>
        /// List of Airport instances
        /// </summary>
        protected readonly List<Airport> _airports;

        /// <summary>
        /// Gets list of Airport instances.
        /// </summary>
        /// <remarks>This is a read-only list. You cannot add/remove items.</remarks>
        public IList<Airport> Airports
        {
            get => new List<Airport>(_airports).AsReadOnly();
        }

        /// <summary>
        /// Constructors airport manager
        /// </summary>
        public AirportManager()
        {
            _airports = new List<Airport>();

            LoadAirports();
        }

        /// <summary>
        /// Populates list with Airport instances from .csv file.
        /// </summary>
        protected abstract void LoadAirports();
    }
}
