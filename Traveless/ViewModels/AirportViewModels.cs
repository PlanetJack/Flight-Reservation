using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveless.Manager.Entities;

/**
 * Instructor notes:
 * The comboboxes only display one item so a collection of strings is needed.
 * The Airports property creates a new List instance from an existing List instance.
 *  This is to maintain the integrity of the existing List instance (so changing something in this list doesn't affect the other one)
 */

namespace Traveless.ViewModels
{
    /// <summary>
    /// Holds view models for airports
    /// </summary>
    public class AirportViewModels : ObservableCollection<string>
    {
        public AirportViewModels(IList<Airport> airports)
        {
            foreach (Airport airport in airports)
            {
                Add(airport.ToString());
            }
        }

    }
}
