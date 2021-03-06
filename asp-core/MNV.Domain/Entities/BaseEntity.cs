using System;
using System.Collections.Generic;
using System.Text;

namespace MNV.Domain.Entities
{
    public class BaseEntity
    {
		public long ID { get; set; }
		public Guid Key { get; set; }
		public long? CreatedByID { get; set; }
		public long? ModifiedByID { get; set; }
		public DateTimeOffset DateCreated { get; set; }
		public DateTimeOffset? DateModified { get; set; }
		public bool Active { get; set; }
	}
}
