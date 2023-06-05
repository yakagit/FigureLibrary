using System;

namespace FigureLibrary
{
    internal class Program
    {
        static void Main()
        {
            //в ТЗ сказано, что необходимо разработать лишь библиотеку
            //на всякий случай в дополнение написал немного кода
            //для демонстрации работы созданных классов и интерфейса
            //дополнительно создал UNIT-тесты

            Console.WriteLine("Выберите фигуру:");
            Console.WriteLine("1) Треугольник");
            Console.WriteLine("2) Круг");

            int figureChoice = Convert.ToInt32(Console.ReadLine());

            switch(figureChoice)
            {
                case 1:
                    Console.WriteLine("Введите значения длин сторон треугольника:");

                    Console.WriteLine("Сторона #1:");
                    double sideA = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Сторона #2:");
                    double sideB = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Сторона #3:");
                    double sideC = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Выберите параметр треугольника, который хотите определить:");
                    Console.WriteLine("1) Площадь");
                    Console.WriteLine("2) Является ли прямоугольным");

                    int triangleActChoice = Convert.ToInt32(Console.ReadLine());

                    switch (triangleActChoice)
                    {
                        case 1:
                            getArea(new Triangle(sideA, sideB, sideC));
                            break;
                        case 2:
                            Triangle triangle = new Triangle(sideA, sideB, sideC);
                            bool checkIsRightTriangle = triangle.IsRightTriangle();
                            string isRightTriangle = (checkIsRightTriangle) ? "является" : "не является";
                            Console.WriteLine($"Треугольник со сторонами {sideA}, {sideB}, {sideC} {isRightTriangle} прямоугольным.");
                            break;
                        default:
                            Console.WriteLine("Ошибка! Выберите действие из предложенного списка.");
                            return;
                    }
                    break;

                case 2:
                    Console.WriteLine("Для определения радиуса круга необходимо ввести радиус фигуры:");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    getArea(new Circle(radius));
                    break;
                default:
                    Console.WriteLine("Ошибка! Выберите фигуру из предложенного списка.");
                    return;
            }

            void getArea(IFigure figure)
            {
                Console.WriteLine($"Площадь фигуры \"{figure}\": {figure.CalculateArea()}");
            }

            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть окно...");
            Console.ReadKey();
        }
    }
}
