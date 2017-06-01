using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.Core.Domain
{
    public class Room
    {
        public Guid Id { get; private set; }
        public Guid CinemaId { get; private set; }
        public int Number { get; private set; }

        public IEnumerable<Seat> Seats { get; private set; }
    }
}
