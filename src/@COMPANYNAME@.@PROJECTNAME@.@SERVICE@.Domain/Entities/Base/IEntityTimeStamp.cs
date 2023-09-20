using System;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Domain.Entities.Base
{
    public interface IEntityTimeStamp
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}