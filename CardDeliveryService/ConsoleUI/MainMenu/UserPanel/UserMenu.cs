using CardDeliveryService.Domain.Entities;
using CardDeliveryService.Services.Services.CardService;
using CardDeliveryService.Services.Services.UserService;

namespace CardDeliveryService.Presentation.ConsoleUI.MainMenu.UserPanel;

public class UserMenu
{
    private User user;

    private UserService userService;
    private CardService cardService;

    public UserMenu(User user, UserService userService, CardService cardService)
    {
        this.user = user;
        this.userService = userService;
        this.cardService = cardService;
    }

    public async Task MenuAsync()
    {

    }
}
