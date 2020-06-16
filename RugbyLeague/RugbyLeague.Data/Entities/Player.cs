using System;
using System.Collections.Generic;

namespace RugbyLeague.Data.Entities
{
    public partial class Player
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public DateTime CreatedDate { get; set; }
        public int TeamId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual Team Team { get; set; }
    }
}
