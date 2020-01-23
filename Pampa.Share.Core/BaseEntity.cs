using System;
using System.Collections.Generic;
using System.Text;

namespace Pampa.Share.Core
{
   public class BaseEntity
    {
        public DateTime CreationTime { get; set; }

        public bool? IsDeleted { get; set; }

        public long? CreatorUserId { get; set; }

        public long DeletedUserId { get; set; }

        public long Id { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        public long? LastUpdatedBy { get; set; }

    }
}
