using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RugbyLeague.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public DateTime CreatedDate { get; set; }
        public int DivisionId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string FullAddress { get; set; }
    }
}
