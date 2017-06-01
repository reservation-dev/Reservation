using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.Core.Domain
{
    public class Seat
    {
        public Guid Id { get; private set; }
        public Guid RoomId { get; private set; }
        public int Number { get; private set; }
        public string Row { get; private set; }
    }
}
