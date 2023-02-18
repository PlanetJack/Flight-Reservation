using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Traveless.Manager.Entities
{
    /// <summary>
    /// Represents a Flight
    /// </summary>
    public class Flight : IEquatable<Flight>
    {
        /// <summary>
        /// Flight code (LL-DDDD)
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Where flight is departing from.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Where flight is arriving to.
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Day flight departs
        /// </summary>
        public string WeekDay { get; set; }

        /// <summary>
        /// Time flight departs
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Number of total seats on flight.
        /// </summary>
        public int TotalSeats { get; set; }

        /// <summary>
        /// Cost per seat
        /// </summary>
        public decimal CostPerSeat { get; set; }

        /// <summary>
        /// Whether flight is domestic (Canada -> Canada)
        /// </summary>
        [JsonIgnore]
        public bool IsDomestic
        {
            get
            {
                if (From[0] == 'Y' && To[0] == 'Y')
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Two letter airline code
        /// </summary>
        [JsonIgnore]
        public string AirlineCode
        {
            get
            {
                return Code.Substring(0, 2);
            }
        }

        /// <summary>
        /// Four digit flight number
        /// </summary>
        [JsonIgnore]
        public int FlightNumber
        {
            get
            {
                return int.Parse(Code.Substring(3));
            }
        }

        /// <summary>
        /// Zero arg constructor for Flight
        /// </summary>
        public Flight()
        {

        }

        /// <summary>
        /// Argument constructor for Flight
        /// </summary>
        /// <param name="code"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="weekday"></param>
        /// <param name="time"></param>
        /// <param name="seats"></param>
        /// <param name="costPerSeat"></param>
        public Flight(string code, string from, string to, string weekday, string time, int seats, decimal costPerSeat)
        {
            Code = code;
            From = from;
            To = to;
            WeekDay = weekday;
            Time = time;
            TotalSeats = seats;
            CostPerSeat = costPerSeat;
        }

        /// <summary>
        /// Checks if this Flight instance equals another Flight instance.
        /// </summary>
        /// <param name="other">Other flight</param>
        /// <returns>True if they're equal</returns>
        public bool Equals(Flight? other)
        {
            if (other == null) return false;
            if (this == other) return true;

            return Code == other.Code;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Flight);
        }
    }
}
