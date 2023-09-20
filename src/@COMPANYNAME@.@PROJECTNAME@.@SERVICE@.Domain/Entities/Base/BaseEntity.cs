using System;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Domain.Entities.Base
{
    public class BaseEntity<TKey> : EntityTimeStamp where TKey : IEquatable<TKey>
    {
        public Guid Id { get; set; }
    }
}
