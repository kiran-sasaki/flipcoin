namespace random
{

    class Program
    {

        public static void Main(string[] args)
        {
            int headcount = 0;
            int tailcount = 0;

            double headpercentage = 0;
            double tailpercentage = 0;

            Console.WriteLine("please enter the no of flips");
            int flips = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < flips; i++)
            {
                Random obj = new Random();

                int num = obj.Next(2);

                if (num == 0)
                {
                    Console.WriteLine("tail");
                    tailcount++;
                }
                else
                {
                    Console.WriteLine("head");
                    headcount++;
                }

            }
            headpercentage = (headcount * 100) / flips;
            tailpercentage = (tailcount * 100) / flips;
            Console.WriteLine("tailpercentage " + tailpercentage);
            Console.WriteLine("headpercentage " + headpercentage);

        }

    }





}
