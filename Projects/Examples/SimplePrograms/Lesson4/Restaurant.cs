namespace Lesson4
{
    class Restaurant<T>
    {
        //Метод MadeFood(ICook someFood) зможе приймати в себе БУДЬ\ЯКИЙ
        //об'єкт, клас якого реалізував логіку інтерфейсу ICook
        public void MadeFood(ICook<T> someFood)
        {
            someFood.GetFood();
        }
    }
}
