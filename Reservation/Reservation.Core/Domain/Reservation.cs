using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.Core.Domain
{
    public class Reservation
    {
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public Guid FilmId { get; private set; }
        public Guid SeatId { get; private set; }
    }
}
