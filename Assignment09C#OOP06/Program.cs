namespace Assignment09C_OOP06
{
    internal class Program
    {//Assignment09C#OOP06
        static void Main(string[] args)
        {


            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());


            Duration D2 = new Duration(1, 30, 15);
            Console.WriteLine(D1.ToString());

            // Duration D1 = new Duration(3600);
            // Console.WriteLine(D1.ToString());

            // Duration D2 = new Duration(7800);
            // Console.WriteLine(D2.ToString());

            // Duration D3 = new Duration(666);
            //Console.WriteLine(D3.ToString());



            //Duration D3 = D2 + D1;

            //Console.WriteLine(D3.ToString());

            //Duration D3 = D2 + 14566;

            //Console.WriteLine(D3.ToString());

            //  Duration D3 = D1+ 14566;

            //Console.WriteLine(D3.ToString());

            //    Duration D3 = ++D2;
            //    Duration D4 = --D2;
            //    Console.WriteLine(D3.ToString());
            //    Console.WriteLine(D4.ToString());

            if (D1 > D2)
                Console.WriteLine("D1 is greater than D2");
            else if (D1 < D2)
            
                Console.WriteLine("D1 is less than  to D2");
            
            else
                Console.WriteLine("D1 is equal to D2");
        }
    }
}
