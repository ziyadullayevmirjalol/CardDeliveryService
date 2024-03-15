using CardDeliveryService.Services.Services.AdminService;
using CardDeliveryService.Services.Services.CardService;
using CardDeliveryService.Services.Services.UserService;

namespace CardDeliveryService.Presentation.ConsoleUI.MainMenu.AdminPanel;

public class AdminMenu
{
    private UserService userService;
    private AdminService adminService;
    private CardService cardService;

    public AdminMenu(UserService userService, AdminService adminService, CardService cardService)
    {
        this.adminService = adminService;
        this.userService = userService;
        this.cardService = cardService;
    }

    public async Task MenuAsync()
    {

    }

}
