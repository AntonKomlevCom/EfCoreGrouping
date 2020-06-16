using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RugbyLeague.Models
{
    public class PlayerModel
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public DateTime CreatedDate { get; set; }
        public int TeamId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
    }
}
