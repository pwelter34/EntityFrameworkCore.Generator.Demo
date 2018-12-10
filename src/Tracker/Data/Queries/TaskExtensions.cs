using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Tracker.Data.Queries
{
    public static partial class TaskExtensions
    {
        #region Generated Extensions
        public static Tracker.Data.Entities.Task GetByKey(this IQueryable<Tracker.Data.Entities.Task> queryable, Guid id)
        {
            if (queryable is DbSet<Tracker.Data.Entities.Task> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Tracker.Data.Entities.Task> GetByKeyAsync(this IQueryable<Tracker.Data.Entities.Task> queryable, Guid id)
        {
            if (queryable is DbSet<Tracker.Data.Entities.Task> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Tracker.Data.Entities.Task> ByAssignedId(this IQueryable<Tracker.Data.Entities.Task> queryable, Guid? assignedId)
        {
            return queryable.Where(q => (q.AssignedId == assignedId || (assignedId == null && q.AssignedId == null)));
        }

        public static IQueryable<Tracker.Data.Entities.Task> ByPriorityId(this IQueryable<Tracker.Data.Entities.Task> queryable, Guid? priorityId)
        {
            return queryable.Where(q => (q.PriorityId == priorityId || (priorityId == null && q.PriorityId == null)));
        }

        public static IQueryable<Tracker.Data.Entities.Task> ByStatusId(this IQueryable<Tracker.Data.Entities.Task> queryable, Guid statusId)
        {
            return queryable.Where(q => q.StatusId == statusId);
        }

        #endregion

    }
}
