using System.ComponentModel.DataAnnotations;

namespace Cofee_Cafe.Models
{
    public class Login
    {
        [Key]
        public string uname { get; set; }
        public string upass { get; set; }


    }
}
