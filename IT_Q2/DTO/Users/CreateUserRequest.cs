using System.ComponentModel.DataAnnotations;

namespace IEQ2_BSIT32E1_OSIANA.Model.Users
{
    public class CreateUserRequest
    {
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
