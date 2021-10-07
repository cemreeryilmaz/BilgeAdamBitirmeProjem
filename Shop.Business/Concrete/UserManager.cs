using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Shop.Business.Abstract;
using Shop.DataAccess.Abstract;
using Shop.Entities.Concrete;

namespace Shop.Business.Concrete
{
    public class UserManager: IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAll()
        {
            return _userDal.GetList();
        }

        public User GetById(int userId)
        {
            return _userDal.Get(u => u.UserId == userId);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }
    }
}