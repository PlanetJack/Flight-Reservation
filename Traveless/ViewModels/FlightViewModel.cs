using Traveless.Manager.Entities;

/**
 * Instructor Notes:
 * This class is used to display a flight in the listview.
 * It is easier to have a add FlightViewModel instance to the listview, than directly adding a Flight instance.
 * In order for it to work with XAML:
 *  - The class must be public
 *  - The properties must be public
 *  - The property names must match EXACTLY to what's specified in the XAML
 *  - The properties must have both get AND set.
 */

namespace Traveless.ViewModels
{
    /// <summary>
    /// Representation of Flight for XAML
    /// </summary>
    public class FlightViewModel
    {
        /// <summary>
        /// Associated Flight instance
        /// </summary>
        public Flight Flight { get; }

        /// <summary>
        /// Flight code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Departure airport code
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Destination airport code
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Scheduled day of the week for flight
        /// </summary>
        public string WeekDay { get; set; }

        /// <summary>
        /// Schedule time when flight leaves
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Number of available seats on flight
        /// </summary>
        public string AvailableSeats { get; set; }

        /// <summary>
        /// Cost per seat (as human readable string)
        /// </summary>
        public string CostPerSeat { get; set; }

        /// <summary>
        /// Constructor for FlightViewModel
        /// </summary>
        /// <param name="flight">Flight to build view model from</param>
        /// <param name="availableSeats">Number of available seats (taken from reservations)</param>
        public FlightViewModel(Flight flight, int availableSeats)
        {
            Flight = flight;

            Code = flight.Code;
            From = flight.From;
            To = flight.To;
            WeekDay = flight.WeekDay;
            Time = flight.Time;
            CostPerSeat = flight.CostPerSeat.ToString("C");
            AvailableSeats = availableSeats.ToString();
        }
    }
}
