using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ReportServer.Controllers;

[ApiController]
[Route("[controller]")]
public class ReportController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;

    public ReportController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Post([FromBody] ReportData reportData)
    {
        // 로그 처리 예시
        _logger.LogInformation($"Received report: {JsonConvert.SerializeObject(reportData)}");

        // 간단한 응답
        return Ok(new { messageId = $"{reportData.MessageId}" });
    }
}
