namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Application.Models.Base
{
    public class FilterRequest
    {
        public string Search { get; set; }
        public int PageSize { get; set; }
        public int Page { get; set; } = 1;
    }
}
