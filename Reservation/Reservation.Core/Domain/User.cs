using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.Core.Domain
{
    public class User
    {
        public Guid Id { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Salt { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public DateTime RegesteredAt { get; private set; }
    }
}
