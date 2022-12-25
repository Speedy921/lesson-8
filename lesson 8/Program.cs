
//понятие структура 
//подходит для моделирования в приложении мматематических и геометрических и др атомарных сушностей

Console.WriteLine("******A First Look Structures***** \n");
//Создать переменную типа Point 
Point myPoint;
myPoint.X = 349;
myPoint.Y = 76;
myPoint.Display();

//Скорректировать значение Х и Y
myPoint.Increment();
myPoint.Display();
Console.ReadLine();

struct Point
{
    //поля структуры 
    public int X;
    public int Y;

    //добавить 1 к позиции (X,Y)
    public void Increment()
    {
        X++; Y++;
    }

    //выченсть 1 из позиции (X,Y)
    public void Decrement()
    {
        X--; Y--;
    }

    //Отобразить текущую позицию
    public void Display()
    {
        Console.WriteLine("X={0}, Y={1}", X, Y);
    }
}