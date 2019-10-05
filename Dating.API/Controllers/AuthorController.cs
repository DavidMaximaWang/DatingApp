using System.Threading.Tasks;
using Dating.API.Data;
using Dating.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dating.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthorController(IAuthRepository repo)
        {
            _repo = repo;

        }

        public async Task<IActionResult> Register(string username, string password){

            username = username.ToLower();
            if (!await _repo.UserExists(username))
                return null;
            var userToCreate  = new User{
                Username= username
            };

            var createdUser = await  _repo.Register(userToCreate, password);
            //todo createdAtRout
            return StatusCode(201);


        }

    }
}