using CardDeliveryService.Domain.Commons;
using CardDeliveryService.Domain.Enums;

namespace CardDeliveryService.Domain.Entities;

public class Card : Auditable
{
    public Bank bank { get; set; }
    public string CardName { get; set; }
    public string CardNumber { get; set; }
    public User? CardHolder { get; set; }
    public long? CardHolderId { get; set; }
}
