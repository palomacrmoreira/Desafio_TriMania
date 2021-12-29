using System.Collections.Generic;
using System;

namespace Desafio_TriMania.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreationDate { get; set; }
        public Adress Adress { get; set; }
        public Basket Basket { get; set; }
        public List<Order> Orders { get; set; }

        public User()
        {

        }
        public User(int userId, string name, string login, string password, string cpf, string email,
         DateTime birthday, Adress adress)
        {
            
            this.Orders = new List<Order>();
            //qual a diferença de criar um objeto aqui e passar o parâmetro order
            this.Name = name;
            this.UserId = userId;
            this.Login = login;
            this.Password = default;
            this.Cpf = cpf;
            this.Email = email;
            this.Birthday = birthday;
            this.Adress = adress;
            CreationDate = DateTime.Now;

        }

    }
}