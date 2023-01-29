using System;
namespace RpgLogicProject
{
    //Класс отвечающий за вещь в рюкзаке

    //Класс отвечающий за вещь в рюкзаке
    public class Item
    {
        public string Name { get; set; }
        public int Weigth { get; set; }
        public int Damage { get; set; } 

        public Item(string name, int weigth, int damage)
        {
            Name = name;
            Weigth = weigth;
            Damage = damage;
        }
    }
}

