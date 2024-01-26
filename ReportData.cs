public class ReportData
{
    // 메시지 아이디: 메시지를 고유하게 식별하는 ID
    public string MessageId { get; set; } = "{messageId}";

    // 결과 코드: API 처리 결과를 나타내는 코드
    public string ResultCode { get; set; } = "{resultCode}";

    // 에러 텍스트: 오류 발생시 상세한 오류 메시지 (Nullable)
    public string? ErrorText { get; set; }

    // 리포트 수신 시간: 메시지의 리포트가 수신된 시간 (ex 2024-01-25 10:00:00)
    public string ReportTime { get; set; } = "yyyy-MM-dd HH:mm:ss";

    // 브랜드톡 타입: 브랜드톡 메시지 타입 (Nullable)
    public string? BrandtalkType { get; set; }

    // 참조 필드: API 요청시 제공한 참조값 (Nullable)
    public string? Ref { get; set; }
}
