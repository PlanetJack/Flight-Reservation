using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Manager.Exceptions
{
    /// <summary>
    /// Thrown if unable to make a reservation
    /// </summary>
    public class MakeReservationException : Exception
    {
        public MakeReservationException() : base("Cannot make reservation") { }
        public MakeReservationException(string message) : base(message) { }
    }
}
