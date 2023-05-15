using AM.API.DataTranferObjects;
using AM.API.Entities;
using AM.API.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UsersController(IUserRepository userRepository,IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;   
            
        }
        [HttpGet]
        [Route("ListofUser")]
        public ActionResult<List<UserReadDto>> Get()
        {
            var users=_userRepository.GetAllUsers();
            var userReadDto=_mapper.Map<List<UserReadDto>>(users);
            return Ok(userReadDto);
        }
        [HttpGet]
        [Route("GetUserById")]
        public ActionResult<UserReadDto> Get(Guid guid)
        {
            var user=_userRepository.GetUserById(guid);
   
            var userReadDto = _mapper.Map<UserReadDto>(user);
            return Ok(userReadDto);
        }
        [HttpPost]
        [Route("CreateUser")]
        public ActionResult<UserReadDto> Post([FromBody] UserCreateDto user)
        {
            // Map CreateUserDto to User
            var createduser=_mapper.Map<User>(user);    

            //Create User
            var createduserRepo=_userRepository.CreateUser(createduser);

            // Map user to UserReadDto
            var userReadDto = _mapper.Map<UserReadDto>(createduserRepo);
            return Ok(userReadDto);

        }

    }
}
