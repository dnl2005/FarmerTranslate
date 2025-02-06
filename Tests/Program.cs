using ClassLibrary;

static double triangle(int per)
{
    return Farmer.CorTriangle(per);
}

static double rectangle(int per)
{
    return Farmer.Rectangle(per);
}
static double circle(int per)
{
    return Farmer.Circle(per);
}

static double square(int per)
{
    return Farmer.Square(per);
}

static double rhombus(int per)
{
    return Farmer.Rhombus(per);
}

static double pentagon(int per)
{
    return Farmer.CorPentagon(per);
}

static double hexogon(int per)
{
    return Farmer.CorHexagon(per);
}

static double nagnle(int per, int side)
{
    return Farmer.CorNgon(per,side);
}

Console.WriteLine("Для периметра 16");
Console.WriteLine($"Круг: {circle(16)}");
Console.WriteLine($"Треугольник: {triangle(16)}");
Console.WriteLine($"Ромб: {rhombus(16)}");
Console.WriteLine($"Прямоугольник: {rectangle(16)}");
Console.WriteLine($"Квадрат: {square(16)}");
Console.WriteLine($"Пятиугольник: {pentagon(16)}");
Console.WriteLine($"Шестиугольник: {hexogon(16)}");
Console.WriteLine($"N-угольник (10): {nagnle(16, 10)}");
Console.WriteLine($"N-угольник (20): {nagnle(16, 20)}");
Console.WriteLine($"N-угольник (100): {nagnle(16, 100)}");
