using System.ComponentModel.DataAnnotations;

namespace NewsBlog.Models
{
    public class Role
    {
        //може бути три ролі "Admin", "Editor", "Client". Внесемо в базу,
        //використовуємо для динамічного додавання кожному клієнту
        [Key]
        public int RoleId { get; set; }
        public string Name { get; set; }

        public Role()
        {

        }
    }
}
