using Traveless.Manager.Entities;
using System.Text.Json;
using System.Text.Json.Serialization;
using Traveless.Manager.Exceptions;

namespace Traveless.Manager.Abstract
{
    /// <summary>
    /// Manages reservations
    /// DO NOT MODIFY THIS FILE
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Feb 12, 2023</remarks>
    public abstract class ReservationManager
    {
        /// <summary>
        /// Path to reservations.json file
        /// </summary>
        public static readonly string RESERVATIONS_JSON_FILE = "Data/reservations.json";

        /// <summary>
        /// List of Reservation instances
        /// </summary>
        protected readonly List<Reservation> _reservations;

        /// <summary>
        /// Gets new list of Reservation instances.
        /// </summary>
        /// <remarks>This is a read-only list. You cannot add/remove items.</remarks>
        public IList<Reservation> Reservations
        {
            get => new List<Reservation>(_reservations).AsReadOnly();
        }

        /// <summary>
        /// Constructs reservation manager
        /// </summary>
        public ReservationManager()
        {
            _reservations = new List<Reservation>();

            if (File.Exists(RESERVATIONS_JSON_FILE))
                LoadFromFile();
        }

        /// <summary>
        /// Makes a reservation
        /// </summary>
        /// <param name="flight">Flight to apply reservation to</param>
        /// <param name="name">Name</param>
        /// <param name="citizenship">Citizenship</param>
        /// <returns>Created Reservation instance</returns>
        /// <exception cref="MakeReservationException">Thrown if unable to make reservation</exception>
        public abstract Reservation MakeReservation(Flight flight, string name, string citizenship);

        /// <summary>
        /// Finds reservation with code
        /// </summary>
        /// <param name="code">Code</param>
        /// <returns>Reservation instance or null if not found</returns>
        public abstract Reservation? FindReservationByCode(string code);

        /// <summary>
        /// Updates an existing reservation
        /// </summary>
        /// <param name="code">Code of existing reservation</param>
        /// <param name="name">Name to change reservation to</param>
        /// <param name="citizenship">Citizenship to change reservation to</param>
        /// <param name="isActive">Whether reservation is active or inactive</param>
        /// <exception cref="UpdateReservationException">Thrown if unable to update reservation</exception>
        public abstract void Update(string code, string name, string citizenship, bool isActive);

        /// <summary>
        /// Determines number of available seats for flight
        /// </summary>
        /// <param name="flight">Flight instance</param>
        /// <returns>Number of available seats</returns>
        public abstract int AvailableSeats(Flight flight);

        /// <summary>
        /// Loads reservations from .json file
        /// </summary>
        private void LoadFromFile()
        {
            string json = File.ReadAllText(RESERVATIONS_JSON_FILE);

            List<Reservation>? reservations = JsonSerializer.Deserialize<List<Reservation>>(json, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.Preserve });

            if (reservations == null)
            {
                return;
            }

            _reservations.AddRange(reservations);
        }

        /// <summary>
        /// Saves reservations to .json file
        /// </summary>
        public void Save()
        {
            string json = JsonSerializer.Serialize(_reservations, new JsonSerializerOptions() { WriteIndented = true, ReferenceHandler = ReferenceHandler.Preserve });

            File.WriteAllText(RESERVATIONS_JSON_FILE, json);
        }
    }
}
