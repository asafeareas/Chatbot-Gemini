using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    private static readonly string apiKey = Environment.GetEnvironmentVariable("GEMINI_API_KEY");
    private static readonly string apiUrl = "https://generativelanguage.googleapis.com/v1beta/models/gemini-pro:generateContent?key=" + apiKey;

    static async Task Main(string[] args)
    {
        Console.WriteLine("Digite sua pergunta:");
        string pergunta = Console.ReadLine();

        string resposta = await PerguntarAoGemini(pergunta);
        Console.WriteLine("Resposta do Gemini:");
        Console.WriteLine(resposta);
    }

    private static async Task<string> PerguntarAoGemini(string pergunta)
    {
        using (HttpClient client = new HttpClient())
        {
            var requestBody = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new[]
                        {
                            new
                            {
                                text = pergunta
                            }
                        }
                    }
                }
            };

            string jsonBody = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(apiUrl, content);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                var resposta = JsonConvert.DeserializeObject<GeminiResponse>(jsonResponse);
                return resposta?.candidates[0]?.content?.parts[0]?.text ?? "Resposta não encontrada.";
            }
            else
            {
                return $"Erro: {response.StatusCode}";
            }
        }
    }

    private class GeminiResponse
    {
        public Candidate[] candidates { get; set; }
    }

    private class Candidate
    {
        public Content content { get; set; }
    }

    private class Content
    {
        public Part[] parts { get; set; }
    }

    private class Part
    {
        public string text { get; set; }
    }
}