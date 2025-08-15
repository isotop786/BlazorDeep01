using System.ComponentModel.DataAnnotations;

namespace BlazorDeep01.Models
{
    public class Server
    {

        public Server()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(0, 2);

            IsOnline = randomNumber == 0 ? false : true;
        }

        public int ServerId { get; set; }

        public bool IsOnline { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = ("Server name must be at least 3 characters"))]
        public string? Name { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = ("City name must be at least 3 characters"))]
        public string? City { get; set; }


    }
}
