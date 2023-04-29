using ChatGpt.Models;
using ChatGpt.Models.Beta;
using ChatGpt.Models.Official;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace ChatGpt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerChat : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public ControllerChat(HttpClient http)
        {
            _httpClient = http;
        }

        [HttpGet]
        [Route("TestBeta")]

        public async Task<IActionResult> Get(string text, [FromServices] IConfiguration configuration)
        {
            var token = configuration.GetValue<string>("ChatToken");
            Console.Write(token);
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var model = new ChatInputModelBeta(text);
            var bodyrequest = JsonSerializer.Serialize(model);
            var content = new StringContent(bodyrequest, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://api.openai.com/v1/chat/completions", content);
            var result = await response.Content.ReadFromJsonAsync<ChatGptResponseModel>();
            var promptResponse = result.choices.First();
            return Ok(new ResponseFinally {  Mensagem =  promptResponse.message.content.Replace("\t", "").Replace("\n", ""), QuantidadeUsada = result.usage.total_tokens});
        }
    }
}
