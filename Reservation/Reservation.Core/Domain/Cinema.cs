using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reservation.Core.Domain
{
    public class Cinema
    {
        public Guid Id { get; private set; }
        public Guid CityId { get; private set; }
        public string Name { get; private set; }

        public IEnumerable<Room> Rooms { get; private set; }
        public IEnumerable<Film> Films { get; private set; }
    }
}
