using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EUserManager.Data
{
    public class EntityUser
    {
        [Table("Users")]
        public class User
        {
            public int Id { get; set; }

            [Required]
            public string Email { get; set; }
            public string Password { get; set; }
            public string Username { get; set; }
            public DateTime UpdateDate { get; set; }
            public DateTime CreateDate { get; set; }
        }
    }
}
