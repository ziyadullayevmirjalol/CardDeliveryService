using CardDeliveryService.DataAccess.Repositores;
using CardDeliveryService.Domain.Entities;
using CardDeliveryService.DTOs.CardModels;
using CardDeliveryService.Services.Interfaces;

namespace CardDeliveryService.Services.Services.CardService;

public class CardService : ICardService
{
    private Repository<User> repository;
    public CardService(Repository<User> repository)
    {
        this.repository = repository;
    }

    public ValueTask<CardViewModel> CreateCard(CardCreateModel card)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteCard(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<IEnumerable<Card>> GetAllCards()
    {
        throw new NotImplementedException();
    }

    public ValueTask<Card> GetCard(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<CardViewModel> UpdateCard(long id, CardUpdateModel card)
    {
        throw new NotImplementedException();
    }

    public ValueTask<CardViewModel> ViewCard(long id)
    {
        throw new NotImplementedException();
    }
}
