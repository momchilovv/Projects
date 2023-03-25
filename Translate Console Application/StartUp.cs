using System.Text;
using System.Text.Json;

class Program
{
    // You can get your free API key from https://portal.azure.com/.
    private static readonly string key = "your_API_key";
    private static readonly string endpoint = "https://api.cognitive.microsofttranslator.com";

    private static readonly string location = "westeurope";

    public static string? translateFrom = string.Empty;
    public static string? translateTo = string.Empty;

    static async Task Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        await Console.Out.WriteLineAsync($"For all languages supported by Microsoft Translate visit this link:");
        await Console.Out.WriteLineAsync("https://learn.microsoft.com/en-us/azure/cognitive-services/translator/language-support#translation" + Environment.NewLine);

        await Console.Out.WriteLineAsync("Write \'End\' to stop the program." + Environment.NewLine);

        await Console.Out.WriteLineAsync("Please input the language code you want to translate from: ");
        translateFrom = await Console.In.ReadLineAsync();
        
        await Console.Out.WriteLineAsync("Please input the language code you want to translate to: ");
        translateTo = await Console.In.ReadLineAsync();

        while (true)
        {
            string route = $"/translate?api-version=3.0&from={translateFrom}&to={translateTo}";
            await Console.Out.WriteAsync("Text: ");
            string textToTranslate = Console.ReadLine()!;
            
            if (textToTranslate == "End")
                Environment.Exit(0);
            
            
            object[] body = new object[] { new { Text = textToTranslate } };
            
            var requestBody = JsonSerializer.Serialize(body);

            using var client = new HttpClient();
            using var request = new HttpRequestMessage();

            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri(endpoint + route);
            request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            request.Headers.Add("Ocp-Apim-Subscription-Key", key);
            request.Headers.Add("Ocp-Apim-Subscription-Region", location);

            HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);

            string result = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var text = JsonSerializer.Deserialize<TranslationResponse[]>(result, options);
            
            await Console.Out.WriteAsync("Translated text: ");
            await Console.Out.WriteLineAsync(text?[0].Translations?[0].Text);
        }
    }
}