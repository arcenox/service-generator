using System;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Common.Exceptions
{
    public class ForbiddenException : Exception
    {
        public ForbiddenException() : base("You have no permission for this action!")
        {
        }
    }
}
