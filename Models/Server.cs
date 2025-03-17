﻿namespace ServerManagementProject.Models
{
    public class Server
    {
        public Server()
        {
            Random random = new Random();
            int radomNumber = random.Next(0, 2);
            IsOnline = radomNumber == 0 ? false : true;
        }
       public int Id { get; set; }
        public bool IsOnline { get; set; }
       public string? Name { get; set; }
        public string? City { get; set; }

    }
}
