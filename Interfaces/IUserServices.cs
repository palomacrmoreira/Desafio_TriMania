using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Desafio_TriMania.Data;
using Desafio_TriMania.Models;
using System.Collections.Generic;

namespace Desafio_TriMania.Interfaces
{
    public interface IUserServices
    {
        List<User> GetUsers();

        User GetUser(int id);

        User CreateUser(User user);

        User UpdateUser(User user);

        int DeleteUser(int id);


    }
}