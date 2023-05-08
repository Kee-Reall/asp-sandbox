using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace BlogPlatform.Utils.Atribute
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class CustomUrl : ValidationAttribute
    {
        private static readonly Regex UrlRegex = new Regex(@"^https://([a-zA-Z0-9_-]+\.)+[a-zA-Z0-9_-]+(\/[a-zA-Z0-9_-]+)*\/?$
");

        public CustomUrl()
        {
            ErrorMessage = "The {0} field must be a valid URL.";
        }

        public override bool IsValid(object value)
        {
            if (value == null)
                return true;

            string url = value.ToString();
            return Uri.TryCreate($"http://{url}", UriKind.Absolute, out Uri result) && UrlRegex.IsMatch(result.Host);
        }
    }
}
