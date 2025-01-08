using System.Text;
using Newtonsoft.Json;

namespace Client.Infra;

public class AuthService
{
    public static string AccessToken;

    public async Task<ApiResponse> SignInAsync(string request, string email, string password, bool rememberMe)
    {
        using var httpClient = new HttpClient();
        var singinData = new
        {
            Email = email,
            Password = password,
            RememberMe = rememberMe
        };

        var json = JsonConvert.SerializeObject(singinData);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await httpClient.PostAsync(UrlHelper.Url + request, content);

        if (response.IsSuccessStatusCode)
        {
            var responseContent = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ApiResponse>(responseContent);
            return result;
        }

        var errorContent = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<ApiResponse>(errorContent)!;
    }
}