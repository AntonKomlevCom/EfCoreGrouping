using System;
using System.Collections.Generic;

namespace RugbyLeague.Data.Entities
{
    public partial class Division
    {
        public Division()
        {
            Team = new HashSet<Team>();
        }

        public int Id { get; set; }
        public Guid Uid { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Team> Team { get; set; }
    }
}
