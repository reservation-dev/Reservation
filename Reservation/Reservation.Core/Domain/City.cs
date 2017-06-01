using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.Core.Domain
{
    public class City
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public IEnumerable<Cinema> Cinemas { get; private set; }
    }
}
