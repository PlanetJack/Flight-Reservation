using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Manager.Exceptions
{
    /// <summary>
    /// Thrown if unable to update reservation.
    /// </summary>
    public class UpdateReservationException : Exception
    {
        public UpdateReservationException() : base("Cannot update reservation") { }
        public UpdateReservationException(string message) : base(message) { }
    }
}
