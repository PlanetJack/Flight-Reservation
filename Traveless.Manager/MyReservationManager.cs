using Traveless.Manager.Entities;
using System.Text.Json;
using System.Text.Json.Serialization;
using Traveless.Manager.Exceptions;
using Traveless.Manager.Abstract;

namespace Traveless.Manager
{
    /// <summary>
    /// Manages reservations
    /// </summary>
    public class MyReservationManager : ReservationManager
    {
        /// <summary>
        /// Makes a reservation
        /// </summary>
        /// <param name="flight">Flight to apply reservation to</param>
        /// <param name="name">Name</param>
        /// <param name="citizenship">Citizenship</param>
        /// <returns>Created Reservation instance</returns>
        /// <exception cref="MakeReservationException">Thrown if unable to make reservation</exception>
        public override Reservation MakeReservation(Flight flight, string name, string citizenship)
        {
            /*
             * Throw MakeReservationException if any of the following is true:
             *  - flight argument is null
             *  - name argument is null or empty string
             *  - citizenship argument is null or empty string
             *  - flight has no more available seats
             */

            // Pass flight argument to Reservation.GenerateReservationCode method to generate reservation code.

            // Create Reservation instance from code, flight, name, and citizenship.
            // The reservation is active when it initially created.

            // Add Reservation instance to _reservations list

            // Return Reservation instance

            return null;
        }

        /// <summary>
        /// Finds reservation with code
        /// </summary>
        /// <param name="code">Code</param>
        /// <returns>Reservation instance or null if not found</returns>
        public override Reservation? FindReservationByCode(string code)
        {
            // Loop through reservations
            //  Check current reservation item code matches code argument
            //      Return current reservation item

            // Return null if code isn't found.
            return null;
        }

        /// <summary>
        /// Updates an existing reservation
        /// </summary>
        /// <param name="code">Code of existing reservation</param>
        /// <param name="name">Name to change reservation to</param>
        /// <param name="citizenship">Citizenship to change reservation to</param>
        /// <param name="isActive">Whether reservation is active or inactive</param>
        /// <exception cref="UpdateReservationException">Thrown if unable to update reservation</exception>
        public override void Update(string code, string name, string citizenship, bool isActive)
        {
            // Throw UpdateReservationException if code argument is null or empty

            // Define found boolean variable and assign it false

            // Loop through each reservation
            //  Check if current reservation code matches code argument
            //      Assign name argument to Name property for reservation 
            //      Assign name argument to Name property for reservation 
            //      Assign isActive argument to IsActive property for reservation 
            //      Does you need a for or foreach loop?

            //      Assign true to found

            //      No need to continue looping

            // Throw UpdateReservationException if no reservation was found.
        }

        /// <summary>
        /// Determines number of available seats for flight
        /// </summary>
        /// <param name="flight">Flight instance</param>
        /// <returns>Number of available seats</returns>
        public override int AvailableSeats(Flight flight)
        {
            // Declare int variable used and assign it 0

            // Loop through each reservation
            //  Increment used if reservation has same flight and reservation is active

            // Available seats is total number of seats on flight minus used seats

            return 0;
        }
    }
}
