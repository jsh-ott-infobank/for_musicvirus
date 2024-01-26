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
        // HTTP 요청에서 'X-MessageType' 헤더의 값을 가져옵니다.
        // 가능한 'X-MessageType' 헤더 값 목록:
        // - AL: 알림톡
        // - AI: 이미지 알림톡
        // - FT: 친구톡 텍스트
        // - FI: 친구톡 이미지
        // - FW: 친구톡 와이드 이미지
        // - BI: 브랜드톡 이미지
        // - BW: 브랜드톡 와이드 이미지
        // - MT: MT(문자메시지) failover 접수 실패
        // - RCS: RCS failover 접수 실패
        var messageType = Request.Headers["X-MessageType"].FirstOrDefault() ?? String.Empty;

        // ReportData 객체와 messageType을 로깅합니다.
        _logger.LogInformation($"Received message type: '{messageType}', Report: {JsonConvert.SerializeObject(reportData)}");

        // TODO: reportData 객체를 DB에 저장하거나, 다른 처리를 수행

        // 요청에 성공적으로 응답하고, messageId를 반환
        return Ok(new { messageId = reportData.MessageId });
    }
}
