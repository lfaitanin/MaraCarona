using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaraCarona.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public Club home { get; set; }
        public Club visitant { get; set; }
        public DateTime gameDate { get; set; }
    }
}
