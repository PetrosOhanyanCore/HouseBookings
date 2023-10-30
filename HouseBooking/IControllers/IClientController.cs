using Microsoft.AspNetCore.Mvc;
using Model;

namespace HouseBooking.IControllers
{
    public interface IClientController
    {
        Task<IActionResult> CreatClientAsync([FromBody] ClientDTO client);
        Task<IActionResult> GetClientAsync(int id);
        Task<IActionResult> GetAllClientAsync();
        Task<IActionResult> PutClientAsync([FromBody] ClientDTO client);
        Task<IActionResult> DeleteClientAsync([FromBody] ClientDTO client);



    }
}
