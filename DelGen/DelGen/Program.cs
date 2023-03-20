using static DelGen.Program;

namespace DelGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Xndir N1
            Console.Write("a = ");
            var a = Console.ReadLine();
            Console.Write("b = ");
            var b = Console.ReadLine();
            static void Gumar<T>(T a, T b)
            {
                Console.WriteLine(Convert.ToDouble(a) + Convert.ToDouble(b));
                Console.WriteLine(Convert.ToDouble(a) * Convert.ToDouble(b));
                Console.WriteLine(Convert.ToDouble(a) / Convert.ToDouble(b));
                Console.WriteLine(Convert.ToDouble(a) - Convert.ToDouble(b));
            }
            Gumar(a, b);
            Console.WriteLine();

            //Xndir N2
            Console.Write("Nermucel zangvaci chapy - ");
            int n = int.Parse(Console.ReadLine());

            //int[] array1 = new int[n];
            Random random = new Random();
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array1[i] = random.Next(0, 10);
            //    Console.Write(array1[i] + " ");
            //}

            double[] array2 = new double[n];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(0,20)*0.01;
                Console.Write(array2[i] + " ");
            }
            static void GetAvg<T>(T[] array1)
            {
                double sum = 0;
                int count = 0;
                for(int i=0;i<array1.Length; i++)
                {
                    sum += Convert.ToDouble(array1[i]);
                    count++;
                }
                Console.Write("Avg = " + sum/count);
            }
            static void GetMax<T>(T[] array1)
            {
                Console.Write(" Max = " + array1.Max());
            }
            //GetAvg(array2);
            //ArrMethods<> arrMethods = new ArrMethods<>(GetAvg(array2));
            ArrMethods<double> del=GetAvg;
            del += GetMax;
            del(array2);
        }
        public delegate void ArrMethods<T>(T[] array);
    }
}