
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

Console.WriteLine("***Using construct***");

//вызвать специальный конструктор
//Ponit2 p2 = new Ponit2(50, 60);
//Выводит х=50, Y= 60;
//p2.Display();

PointWithReadOnly p3 = new PointWithReadOnly(50, 60, "Point w/RO");
p3.Dsiplay();

var s = new DisposableRefStruct(50, 60);
s.Display();
s.Dispose();

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

struct Point2
{
    //поля структуры
    public int X;
    public int Y;

    //Специальный конструктор
    public Point2(int xPos, int yPos)
    {
        X = xPos; Y = yPos;
    }
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


readonly struct ReadOnlyPoint
{
    //Поля структурыю
    public int X { get; }
    public int Y { get; }
    //отобразить теущую позицию
    public void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }  
    
    public ReadOnlyPoint(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }
}

struct PointWithReadOnly
{
    //Поля структуры
    public int X;
    public readonly int Y;
    public readonly string Name;

    //Отобразить текущую позицию и название
    public readonly void Dsiplay()
    {
        Console.WriteLine($"X = {X}, Y = {Y}, Name = {Name}");
    }

    //специальный конструктор
    public PointWithReadOnly(int xPos, int yPos, string name)
    {
        X = xPos;
        Y = yPos;
        Name = name;
    }

}

ref struct DisposableRefStruct
{
    public int X;
    public readonly int Y;
    public readonly void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");

    }
    
   //специальный конструктор
   public DisposableRefStruct(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
        Console.WriteLine("Created!!"); //Экземпляр создан!

    }

   public void Dispose()
    {
        //выполнить здесь очистку любых ресурсов
        Console.WriteLine("Disposed!"); //Экземпляр освобожден!
    }
}
