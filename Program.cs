using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the total number of segments (N): ");
        int N = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the maximum distance (K): ");
        int K = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the population for each segment (separated by spaces): ");
        string input = Console.ReadLine();
        string[] populationStr = input.Split(' ');
        
        int[] population = new int[N];
        for (int i = 0; i < N; i++)
        {
            population[i] = int.Parse(populationStr[i]);
        }
        
        int maxCustomers = 0;
        
        // ทดลองตั้งร้านในแต่ละช่วงถนน
        for (int i = 0; i < N; i++)
        {
            int start = Math.Max(0, i - K);
            int end = Math.Min(N - 1, i + K);
            
            int customers = 0;
            
            // นับจำนวนลูกค้าในช่วงถนนที่อยู่ใกล้ร้าน
            for (int j = start; j <= end; j++)
            {
                customers += population[j];
            }
            
            // อัพเดตจำนวนลูกค้าที่มากที่สุด
            if (customers > maxCustomers)
            {
                maxCustomers = customers;
            }
        }
        
        Console.Write("The maximum number of customers that can come to the store is: ");
        Console.WriteLine(maxCustomers);
    }
}
