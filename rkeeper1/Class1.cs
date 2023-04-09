using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rkeeper
{
    public class User // пользователь
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }

    public class Role // роль
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Dish // блюдо
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ulong Price { get; set; }
        public DishType DishType { get; set; }
    }
    
    public class DishType // вид блюда
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class Order // заказ
    {
        public int Id { get; set; }
        public int Table { get; set; }
        public Dish Dish { get; set; }
        public User User { get; set; }
        public Status Status { get; set; }
    }

    public class Status // статус заказа
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
