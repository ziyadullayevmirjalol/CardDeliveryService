using CardDeliveryService.Domain.Entities;

namespace CardDeliveryService.DTOs.UserModels;

public class UserViewModel
{
    public long Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public IEnumerable<Card>? Cards { get; set; }
}