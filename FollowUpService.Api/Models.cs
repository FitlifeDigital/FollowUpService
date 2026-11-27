namespace FollowUpService.Api.Models;

public class FollowUpCase
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid MemberId { get; set; }
    public Guid TrainerId { get; set; }
    public int InactiveDays { get; set; }
    public string Status { get; set; } = "Pending"; 
    public string NudgeMessage { get; set; }
    public DateTime CreatedAt  { get; set; } = DateTime.UtcNow;
}