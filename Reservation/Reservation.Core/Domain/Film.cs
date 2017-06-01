using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.Core.Domain
{
    public class Film
    {
        public Guid Id { get; private set; }
        public Guid RoomId { get; private set; }
        public Cinema Cinema { get; private set; }
        public string Title { get; private set; }
        public DateTime Start { get; private set; }
        public TimeSpan Duration { get; private set; }
    }
}
