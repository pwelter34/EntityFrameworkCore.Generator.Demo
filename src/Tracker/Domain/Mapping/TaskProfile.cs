using System;
using AutoMapper;
using Tracker.Data.Entities;
using Tracker.Domain.Models;

namespace Tracker.Domain.Mapping
{
    public partial class TaskProfile
        : AutoMapper.Profile
    {
        public TaskProfile()
        {
            CreateMap<Tracker.Data.Entities.Task, Tracker.Domain.Models.TaskReadModel>()
                .ForMember(d => d.AssignedEmail, opt => opt.MapFrom(s => s.AssignedUser.EmailAddress));

            CreateMap<Tracker.Domain.Models.TaskCreateModel, Tracker.Data.Entities.Task>();
            CreateMap<Tracker.Domain.Models.TaskUpdateModel, Tracker.Data.Entities.Task>();
        }

    }
}
