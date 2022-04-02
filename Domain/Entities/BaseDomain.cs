using System;

namespace Domain
{
    public abstract class BaseDomain
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
    }
}
