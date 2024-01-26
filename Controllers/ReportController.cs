using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ReportServer.Controllers;

[ApiController]
[Route("[controller]")]
public class ReportController : ControllerBase
{
    private readonly ILogger<ReportController> _logger;

    // 클래스 생성자
    public ReportController(ILogger<ReportController> logger)
    {
        _logger = logger;
    }

    // POST 요청을 처리하는 액션 메서드
    /*
        curl 예제:

        curl --location 'http://localhost:5223/report' \
            --header 'X-MessageType: AL' \
            --header 'Content-Type: application/json' \
            --data '{
                "messageId": "215219c51c664360a7027fb6751d0425",
                "resultCode": "3018",
                "errorText": "NoSendAvailableException(20240125-5219c51c664360a7027fb6751d0425)",
                "reportTime": "2024-01-25 10:00:00",
                "ref": "{\"aaa\":\"111\"}"
            }'
    */
    [HttpPost]
    public IActionResult Post([FromBody] ReportData reportData)
    {
        // ReportData 객체를 JSON 문자열로 직렬화하여 로깅
        _logger.LogInformation($"Received report: {JsonConvert.SerializeObject(reportData)}");

        // 요청에 성공적으로 응답하고, messageId를 반환
        return Ok(new { messageId = reportData.MessageId });
    }
}
