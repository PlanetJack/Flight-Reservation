using Traveless.Manager.Entities;

namespace Traveless.ViewModels
{
    /// <summary>
    /// Representation of Reservation for XAML
    /// </summary>
    public class ReservationViewModel
    {
        /// <summary>
        /// Reservation instance
        /// </summary>
        public Reservation Reservation { get; }

        /// <summary>
        /// Reservation code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Flight code
        /// </summary>
        public string Flight { get; set; }

        /// <summary>
        /// Name on reservation
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Citizenship of person
        /// </summary>
        public string Citizenship { get; set; }

        /// <summary>
        /// Whether reservation is active
        /// </summary>
        public string IsActive { get; set; }

        /// <summary>
        /// Constructors view model
        /// </summary>
        /// <param name="reservation">Reservation to build view model from</param>
        public ReservationViewModel(Reservation reservation)
        {
            Reservation = reservation;
            Code = reservation.Code;
            Flight = reservation.Flight.Code;
            Name = reservation.Name;
            Citizenship = reservation.Citizenship;
            IsActive = reservation.IsActive.ToString();
        }
    }
}
