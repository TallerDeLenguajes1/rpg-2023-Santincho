using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
namespace API;
public class BoredApiService
{
    private const string ApiUrl = "https://www.boredapi.com/api/activity";

    public async Task<string> GetRandomActivityAsync()
    {
        using (var httpClient = new HttpClient())
        {
            try
            {
                var response = await httpClient.GetAsync(ApiUrl);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();

                // Deserializar la respuesta JSON utilizando System.Text.Json.
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var boredApiResponse = JsonSerializer.Deserialize<BoredApiResponse>(content, options);

                // Obtener la propiedad "activity" de la respuesta deserializada.
                var activity = boredApiResponse.activity;

                return activity;
            }
            catch (HttpRequestException ex)
            {
                // Manejar errores de solicitud HTTP aquí.
                Console.WriteLine($"Error de solicitud HTTP: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                // Manejar otros errores aquí.
                Console.WriteLine($"Error inesperado: {ex.Message}");
                return null;
            }
        }
    }
}

public class BoredApiResponse
{
    public string activity { get; set; }
}