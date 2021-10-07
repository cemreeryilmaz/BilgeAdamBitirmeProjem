using System;
using System.Reflection.Metadata;
using Shop.Core.Entities.Abstract;

namespace Shop.Entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string ImagePath { get; set; }

    }
}