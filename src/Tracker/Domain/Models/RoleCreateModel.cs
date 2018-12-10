using System;
using System.Collections.Generic;

namespace Tracker.Domain.Models
{
    public partial class RoleCreateModel
    {
        #region Generated Properties
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTimeOffset Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTimeOffset Updated { get; set; }

        public string UpdatedBy { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
