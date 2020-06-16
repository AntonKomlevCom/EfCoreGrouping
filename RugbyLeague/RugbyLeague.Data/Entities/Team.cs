using System;
using System.Collections.Generic;

namespace RugbyLeague.Data.Entities
{
    public partial class Team
    {
        public Team()
        {
            Player = new HashSet<Player>();
        }

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

        public virtual Division Division { get; set; }
        public virtual ICollection<Player> Player { get; set; }
    }
}
