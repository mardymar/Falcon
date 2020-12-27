using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class LocalUser
    {
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public string Salt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsLoggedIn { get; set; } = false;

    }
}
