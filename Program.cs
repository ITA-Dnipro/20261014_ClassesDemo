namespace _20261014_ClassesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // DemoMothods();

            Point2D p1 /*= null*/ = new Point2D(17, 21);

            //Console.WriteLine($"Point 1: ({p1.GetX()}, {p1.GetY()})");
            Console.WriteLine($"Point 1: ({p1.X}, {p1.Y})");

            // p1.SetX(17);

            //Console.WriteLine($"Point 1: ({p1.GetX()}, {p1.GetY()})");

            //p1.SetY(-12);
            p1.Y = -12;

            Show(p1);

          //  Console.WriteLine($"Point 1: ({p1.GetX()}, {p1.GetY()})");

            //p1.SetY(19);
            p1.Y = 19;

            Show(p1); 

            Point2D p2 = new Point2D(15);
            Show(p2);
        }

        public static void Show(Point2D p)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            int oldX = Console.CursorLeft;
            int oldY = Console.CursorTop;

            Console.ForegroundColor = ConsoleColor.Red;
            //Console.SetCursorPosition(p.GetX(), p.GetY());
            //Console.Write($"({p.GetX()}, {p.GetY()})");
            Console.SetCursorPosition(p.X, p.Y);
            Console.Write($"({p.X}, {p.Y})");

            Console.SetCursorPosition(oldX, oldY);
            Console.ForegroundColor = oldColor;
        }

        private static void DemoMothods()
        {
            int first = 5;
            int second = 10;

            int result = Add(first, second);    // Call

            Console.WriteLine($"The sum of {first} and {second} is: {result}");

            int result2 = Add(21, 31);    // Call

            Console.WriteLine($"The sum of 21 and 31 is: {result2}");

            //int result3 = 555;
            //Add2(first, second, out result3);    // Call

            int result3;
            Add2(first, second, out /*int*/ result3);    // Call

            Console.WriteLine($"The sum of {first} and {second} is: {result3}");

            int result4 = 888;
            Add3(first, second, ref result4);    // Call

            Console.WriteLine($"The sum of {first} and {second} is: {result4}");
        }

        // Definition
        public static int Add(int a, int b)
        {
            int result = a + b;

            a += 100;

            return result;
        }

        public static void Add2(int a, int b, out int result)
        {
            //int resultCopy = result;

            result = a + b;

            a += 100;
        }

        public static void Add3(in int a, int b, ref int result)
        {
            int resultCopy = result;

            result = a + b;

            // a += 100;

            int aCopy= a;

            aCopy += 100;
        }
    }
}
