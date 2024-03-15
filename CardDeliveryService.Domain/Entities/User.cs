using CardDeliveryService.Domain.Commons;

namespace CardDeliveryService.Domain.Entities;

public class User : Auditable
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public IEnumerable<Card>? Cards { get; set; }
    public string UserCards { get; set; }
}
