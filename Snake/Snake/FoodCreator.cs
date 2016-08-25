using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        //для следующих 3-х полей неявно предполагается наличие ключевого слова private (можно его дописать впереди)
        //все что помечено как private невидимо за пределами класса
        //т.о. скрывается от пользователей, которые используют этот класс, детали реализации этого класса
        //т.о. разрешается пользователям этого класса ипользовать только то, что явно разрешено (ключевое слово - public) 
        int mapWidth; 
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
