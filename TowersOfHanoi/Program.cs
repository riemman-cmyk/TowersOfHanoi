namespace TowersOfHanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number of disks: ");
            int n = Convert.ToInt32(Console.ReadLine());
            place_disk(n, 1, 3);
        }
        static void place_disk(int n, int s, int e)  
        {
            if (n == 1)
            {
                print_placements(n, s, e);
            }
            else
            {
                int k = 6 - e - s;
                place_disk(n - 1, s, k);
                print_placements(n, s, e);
                place_disk(n - 1, k, e);
            }
        }
        static void print_placements(int curr, int s, int e)
        {
            Console.WriteLine($"disk {curr} moved: {s} --> {e}");
        }
    }
}