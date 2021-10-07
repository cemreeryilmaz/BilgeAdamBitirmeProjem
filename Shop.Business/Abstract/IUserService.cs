using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Shop.Entities.Concrete;

namespace Shop.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(int userId);
        void Add(User user);
        void Update(User user);
        void Delete(User user);

    }
}