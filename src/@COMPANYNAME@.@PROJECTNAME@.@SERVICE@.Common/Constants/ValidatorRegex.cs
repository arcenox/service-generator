using System.Text.RegularExpressions;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Common.Constants
{
    public partial class ValidatorRegex
    {

        [GeneratedRegex(@"^(?=[a-zA-Z0-9@._%+-]{6,254}$)[a-zA-Z0-9._%+-]{1,64}@(?:[a-zA-Z0-9-]{1,63}\.){1,8}[a-zA-Z]{2,63}$")]
        public static partial Regex EmailRegexValidator();

        [GeneratedRegex(@"^(?!.*\.\.)(?!.*\.$)[^\W][\w.]{0,29}$")]
        public static partial Regex UserNameRegexValidator();

        [GeneratedRegex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[#$^+=!*()@%&]).{6,}$")]
        public static partial Regex PasswordRegexValidator();
    }
}
