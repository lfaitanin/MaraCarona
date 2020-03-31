using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaraCarona.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public Club club { get; set; }
        public string city { get; set; }
        public UserType type { get; set; }
    }
}
