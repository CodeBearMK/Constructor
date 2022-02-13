namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            Rectangle rect2 = new Rectangle(107, 132);
            Console.WriteLine();
            Console.WriteLine("矩形長度:{0}",rect2.Length);
            Console.WriteLine("矩形寬度:{0}", rect2.Wide);
            Console.Write("矩形面積:{0}", rect2.GetArea(rect2.Length, rect2.Wide));
            Console.Read();
        }
    }
}