namespace D11416129
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrivalTime = Console.ReadLine();
            int r1 = Convert.ToInt32(arrivalTime);

            string delayedTime = Console.ReadLine();
            int r2 = Convert.ToInt32(delayedTime);

            Console.WriteLine(finaltime(r1, r2));




            int finaltime(int arrivalTime, int delayedTime)
            {
                //1.輸入
                //int arrivalTime
                //int delayedTime

                //2.處理
                int comput = arrivalTime + delayedTime;
                comput = comput % 24;
                //3.輸出
                int result = comput;
                return (result);
            }
        }
    }
}

