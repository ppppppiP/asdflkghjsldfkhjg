using System;


namespace RpgLogicProject
{

    public class BackPack
    {
        //Массив обьектов в рюкзаке
        
        private readonly Item[] items;

        //Следующая свободная ячейка
        private int count = 0;

        public int maxWeigth { get; set; }

        public BackPack(int count)
        {
            items = new Item[count];
        }

        public void Add(Item item)
        {

            int a = GetWeigth();
            if (a<maxWeigth)
            {
                items[count] = item;
            }
            else
            {
                Console.WriteLine("перевес");
            }
            //Проверить нет ли перевеса (использовать метод GetWeigth())
            //Проверить есть ли свободная ячейка
            //Добавить item в массив по счетчику count
        }

        public int GetWeigth()
        {
            int result = 0;
            
            for (int i = 1; i < items.Length; i++)
            {
                result += items[i].Weigth;
               
            }

            return result;
        }


    }
}


