using System.Collections.Generic;
using Desafio_TriMania.Interfaces;
using Desafio_TriMania.Models;
using Desafio_TriMania.Data;
using System.Linq;

namespace Desafio_TriMania.Services
{
    public class UserServices : IUserServices
    //a classe UserServices implementa a interface IUserServices
    {
        public readonly ApplicationContext _applicationContext;

        public UserServices(ApplicationContext context)
        {
            _applicationContext = context;
            _applicationContext.Database.EnsureCreated();

        }
        public User CreateUser(User user)
        {
            Basket Basket = new Basket();
            Basket.UserId = user.UserId;
            Basket.User = user;
            user.Basket = Basket;
            _applicationContext.Users.Add(user);
            //_applicationContext.Baskets.Add(Basket);
            _applicationContext.SaveChanges();
            return user;

        }

        public int DeleteUser(int id)
        {
            var DeletedUser = _applicationContext.Users.Where(c => c.UserId == id);
            //como converter o resultado para User?
            //quero mostrar o User deletado
            _applicationContext.Users.Remove(new User { UserId = id });
            _applicationContext.SaveChanges();
            return id;

        }

        public User GetUser(int id)
        {
            return _applicationContext.Users.Find(id);
        }

        public List<User> GetUsers()
        {
            return _applicationContext.Users.ToList();
        }

        public User UpdateUser(User user)
        {
            var NewUser = _applicationContext.Users.Find(user.UserId);
            //achei o usuário corespondente ao id 
            NewUser.Name = user.Name;
            NewUser.Email = user.Email;
            NewUser.Password = user.Password;
            _applicationContext.Update(NewUser);
            _applicationContext.SaveChanges();
            return user;

        }
    }
}