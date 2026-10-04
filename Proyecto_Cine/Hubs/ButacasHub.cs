using Microsoft.AspNetCore.SignalR;

namespace PROYECTO_PROGRA_5.Hubs
{
    public class ButacasHub : Hub
    {
        public async Task UnirseASala(int salaId)
        {
            await Groups.AddToGroupAsync(
                Context.ConnectionId,
                $"sala-{salaId}"
            );
        }

        public async Task SalirDeSala(int salaId)
        {
            await Groups.RemoveFromGroupAsync(
                Context.ConnectionId,
                $"sala-{salaId}"
            );
        }
    }
}
