using System;

namespace UnitTestProject1
{
    public class OrangeTree
    {
        public int age, height, fruit, eaten;
        public bool alive = true;

        public int NumOranges
        {
            get
            {
                return fruit;
            }
            private set
            {
            }
        }
        public int OrangesEaten
        {
            get
            {
                return eaten;
            }
            private set
            {
            }
        }
        public bool TreeAlive
        {
            get
            {
                return alive;
            }
            private set
            {
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            private set
            {
            }
        }
        public int Age
        {
         get
            {
                return age;
            }
          private set
            {
            }
        }

        public OrangeTree(int age, int height)
        {
            this.age = age;
            this.height = height;
        }

        public void OneYearPasses()
        {
            age++;
            height += 2;

            if (age > 2)
            {
                fruit += 5;
            }

            else if (age - (age / 2) == age / 2)
            {
                fruit += 5;
            }

            if(age >= 80)
            {
                height -= 2;
                fruit = 0;
                alive = false;
            }

            eaten = 0;
        }

        public void EatOrange(int v)
        {
            eaten += v;

            if(fruit == 0)
            {
                throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
            }
        }
    }
}