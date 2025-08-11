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

        public string? Name { get; set; }

        public string? City { get; set; }


    }
}
