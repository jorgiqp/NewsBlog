using System.ComponentModel.DataAnnotations;

namespace NewsBlog.Models
{
    public class User
    {
        [Key] //треба для підключення таблиць між собою за допомогою "Id"
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string Email { get; set; }
        public string? Comments { get; set; }
        public string Role { get; set; } //вносимо роль клієнта може бути "Admin", "Editor", "Client"

        public User()
        {

        }

    }
}
