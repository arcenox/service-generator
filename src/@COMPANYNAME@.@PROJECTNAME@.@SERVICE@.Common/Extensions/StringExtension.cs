using System;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Common.Extensions
{
    public static class StringExtension
    {
        public static string FirstCharToUpper(this string input)
          => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1));
    }
}
