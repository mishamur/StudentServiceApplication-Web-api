using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using StudentServiceApplication.Interfaces;
using StudentServiceApplication.ViewModels;
using StudentServiceApplication.DTO;

namespace StudentServiceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslateController : ControllerBase
    {
        private readonly IConfiguration configuration;
        public TranslateController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        private static readonly HttpClient httpClient = new HttpClient()
        {
            BaseAddress = new Uri(@"https://translate.api.cloud.yandex.net/")
        };
        [HttpGet("translate")]
        public async Task<IActionResult> Translate(string sourceLanguage, string targetLanguage, string[] text)
        {
            TranslateRequestDTO translateDto = new TranslateRequestDTO(
                sourceLanguage, targetLanguage, text.ToList(), configuration["YandexApiSetting:FolderId"]
                );

            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(translateDto));
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {configuration["YandexApiSetting:ApiToken"]}");
            //stringContent.Headers.Add("Authorization", $"Bearer {configuration["YandexApiSetting:ApiToken"]}");
            var response = await httpClient.PostAsync("translate/v2/translate", stringContent);
            string responseJson = await response.Content.ReadAsStringAsync();
            dynamic jsonResponse = JsonConvert.DeserializeObject(responseJson);

            string recognizedText = string.Empty;
            if (jsonResponse != null && jsonResponse.translations != null && jsonResponse.translations[0] != null)
            {
                recognizedText = jsonResponse.translations[0].text;
                return Ok(recognizedText);
            }
            return BadRequest();
        }

        [HttpPost("AnalyseText")]
        public async Task<IActionResult> AnalyseText()
        {
            return BadRequest();
        }
    }
}
