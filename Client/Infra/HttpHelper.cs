using System.Text;

namespace Client.Infra;

public class HttpHelper
{
    public string BuildUrlWithQueryParams(string url, object queryObject)
    {
        var properties = queryObject.GetType().GetProperties();
        var queryString = new StringBuilder("?");

        foreach (var property in properties)
        {
            var value = property.GetValue(queryObject);
            if (value != null)
                queryString.AppendFormat("{0}={1}&", property.Name, Uri.EscapeDataString(value.ToString()!));
        }

        return url + queryString.ToString().TrimEnd('&');
    }
}