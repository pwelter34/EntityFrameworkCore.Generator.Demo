using System;

namespace Tracker.Definitions
{
    public interface IHaveIdentifier
    {
        Guid Id { get; set; }
    }
}
