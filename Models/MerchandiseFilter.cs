using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminFrontEnd.Models
{

    public class MerchandiseFilter
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public DateTime DateAndTime { get; set; }
        public int NumberRecordsReturned { get; set; }
    }
}