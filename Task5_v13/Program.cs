namespace Task5_v13
{
    public class Cube
    {
        double rebro;
        public double Repro
        {
            set { rebro = value; }
        }
        public bool Correct()
        {
            bool p = false;
            if (rebro > 0) p = true;
            return p;
        }
        public double Area()
        {
            return 6 * Math.Pow(rebro, 2);
        }
        public double Volume()
        {
            return Math.Pow(rebro, 3);
        }
        public void Print()
        {
            Console.WriteLine("rebro:" + rebro);
        }
        public void Print2()
        {
            
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double r;
            try
            {
                Console.Write("Ребро:"); r = Convert.ToDouble(Console.ReadLine());

                Cube cube = new Cube();
                cube.Repro = r;
                cube.Print();
                if (cube.Correct())
                {
                    Console.WriteLine("S = {0}, V = {1}", cube.Area(), cube.Volume());
                }
                else Console.WriteLine("Такого куба не існує");
            }
            catch
            {
                Console.WriteLine("Error!!!");
            }
        }
            
    }
}
