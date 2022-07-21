namespace Lesson3
{
    class Restaurant<T>
    {
        //Метод MadeFood(ICook someFood) зможе приймати в себе БУДЬ-ЯКИЙ
        //об'єкт, клас якого реалізував логіку інтерфейсу ICook
        public void MadeFood(ICookable<T> someFood)
        {
            someFood.GetFood();
        }
    }
}
