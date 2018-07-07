using System.ComponentModel.DataAnnotations;

namespace formValid
{

    public class User
    {
        [Required]
        [MinLength(4)]
        public string First_Name { get; set; }

        [Required]
        [MinLength(4)]
        public string Last_Name { get; set; }


        [Required]
        [Range(0, 200)]
        public int Age { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }

    }



}