using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using Ahura.Platform.Application.Command.Base;
using Ahura.Platform.Application.Query.Base;
using Ahura.Platform.Application.Query.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Client.Infra;

public class HttpService
{
    public QueryResult<TQr> GetData<TQr, TQ>(string url, TQ query) where TQ : new()
    {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AuthService.AccessToken);
        var fullUrl = new HttpHelper().BuildUrlWithQueryParams(UrlHelper.Url + url, query!);

        try
        {
            var response = client.GetAsync(fullUrl).Result;

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = Error(response);
                throw new Exception($"{errorContent}");
            }

            var responseBodySuccess = response.Content.ReadAsStringAsync().Result;

            var jObjectSuccess = JObject.Parse(responseBodySuccess);

            var qr = new QueryResult<TQr>
            {
                Message = jObjectSuccess["message"]?.ToString()!,
                Status = (ApplicationServiceStatus)Enum.Parse(typeof(ApplicationServiceStatus),
                    jObjectSuccess["status"]?.ToString() ?? "0")
            };

            var dataToken = jObjectSuccess["data"];
            if (dataToken != null) qr._data = dataToken.ToObject<TQr>();

            return qr;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }

    public CommandResult Post<T>(string url, T data)
    {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AuthService.AccessToken);
        try
        {
            var response = client.PostAsJsonAsync(UrlHelper.Url + url, data).Result;
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = Error(response);
                throw new Exception($"{errorContent}");
            }

            var responseBody = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<CommandResult>(responseBody);
            return result;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }

    public CommandResult Put<T>(string url, T data)
    {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AuthService.AccessToken);
        try
        {
            var response = client.PutAsJsonAsync(UrlHelper.Url + url, data).Result;
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = Error(response);
                throw new Exception($"{errorContent}");
            }

            var responseBody = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<CommandResult>(responseBody);
            return result;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }

    public void Delete<T>(string url, T data)
    {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AuthService.AccessToken);

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, UrlHelper.Url + url)
            {
                Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")
            };

            var response = client.Send(request);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = Error(response);
                throw new Exception($"{errorContent}");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }


    private string Error(HttpResponseMessage response)
    {
        var errorContent = response.Content.ReadAsStringAsync().Result;

        if (errorContent.Contains("System.UnauthorizedAccessException: UnAuthorized To Access")) return "عدم دسترسی";


        try
        {
            var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(errorContent);

            var sb = new StringBuilder();

            foreach (var error in errorResponse!.Errors)
            {
                var er = error.Value.ToList();
                var innerSb = new StringBuilder();

                foreach (var e in er)
                {
                    innerSb.Append(e);
                    innerSb.Append(Environment.NewLine);
                    sb.Append(innerSb.ToString());
                }


                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
        catch (Exception e)
        {
            throw new Exception("خطای نامشخص");
        }
    }
}