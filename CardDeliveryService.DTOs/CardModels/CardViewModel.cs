using CardDeliveryService.Domain.Enums;

namespace CardDeliveryService.DTOs.CardModels;

public class CardViewModel
{
    public long Id { get; set; }
    public Bank bank { get; set; }
    public string CardName { get; set; }
    public string CardNumber { get; set; }
    public long? CardHolderId { get; set; }
}

