﻿using CardDeliveryService.Domain.Enums;

namespace CardDeliveryService.DTOs.CardModels;

public class CardCreateModel
{
    public Bank bank { get; set; }
    public string CardName { get; set; }
    public string CardNumber { get; set; }
}

