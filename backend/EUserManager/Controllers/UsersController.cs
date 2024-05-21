using EUserManager.Data;
using EUserManager.Models;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static EUserManager.Data.EntityUser;

namespace EUserManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] Models.RegisterRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (request.Password != request.ConfirmPassword)
                return BadRequest("Passwords do not match");

            // Kiểm tra email tồn tại
            var emailExists = await _context.Users.AnyAsync(u => u.Email == request.Email);
            if (emailExists)
                return BadRequest("Email already exists");

            // Tạo người dùng mới
            var user = new User
            {
                Username = request.Username,
                Email = request.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(request.Password), // Mã hóa mật khẩu
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            var newUser = new User
            {
                Username = request.Username,
                Email = request.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(request.Password), // Mã hóa mật khẩu
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            return Ok(new
            {
                status = 200,
                message = "success",
                data = newUser
            });
        }

        [HttpGet("allusers")]
        public async Task<IActionResult> GetUsers(int pageNumber = 1, int pageSize = 10)
        {
            var users = await _context.Users
                                      .Skip((pageNumber - 1) * pageSize)
                                      .Take(pageSize)
                                      .ToListAsync();

            return Ok(new
            {
                status = 200,
                message = "success",
                data = users
            }); ;
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchUsers(string key)
        {
            var users = await _context.Users
                                      .Where(u => u.Username.Contains(key) || u.Email.Contains(key))
                                      .ToListAsync();

            return Ok(users);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Models.LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == request.Username && u.Password == request.Password); // Nên so sánh với mật khẩu đã mã hóa

            if (user == null)
                return Unauthorized();

            // Tạo và trả về JWT token (cần cấu hình thêm)

            return Ok(new { message = "Login successful" });
        }

        [HttpGet("check_email")]
        public async Task<IActionResult> CheckEmail([FromQuery] string email)
        {
            var exists = await _context.Users.AnyAsync(u => u.Email == email);
            return Ok(new { exists });
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // Xử lý logout
            return Ok(new { message = "Logout successful" });
        }
    }
}

