using System;
namespace RpgLogicProject
{
    public class BattleArena
    {
        public Enemy Enemy { get; set; }
        public Hero Hero { get; set; }
        public Item Item { get; set; }


        public BattleArena(Enemy enemy, Hero hero, Item item)
        {
            Enemy = enemy;
            Hero = hero;
            Item = item;
        }



        public int Battle()
        {

            do
            {
            restart:
                Console.WriteLine($"Ваше здоровье {Hero.Hp}");
                Console.WriteLine($"Здоровье противника {Enemy.Hp}");
                Console.WriteLine($"Вы нанесли урон противнику: {Hero.Damage + Item.Damage}");
                Enemy.Hp -= (Hero.Damage + Item.Damage);
                if (Enemy.Hp <= 0)
                {
                    Console.WriteLine("Вы победили врага!");
                    return 1;
                }

                Console.WriteLine($"Вы получили урон: {Enemy.Damage}");
                Hero.Hp -= Enemy.Damage;
                if (Hero.Hp <= 0)
                {
                    Console.WriteLine("Вы погибли...");
                    return 0;
                }
                else { goto restart; }

            }
            while (Enemy.Hp > 0 && Hero.Hp > 0);


            //Реализовать пошаговый бой до окончании жизни одного из участников битвы
            //Вернуть 1 в случае победы. 0 - поражение

            
        }
    }

}

   


