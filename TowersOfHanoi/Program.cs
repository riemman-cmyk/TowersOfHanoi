namespace TowersOfHanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number of disks: ");
            int n = Convert.ToInt32(Console.ReadLine());
            place_disk(n, 1, 3);
            //sawyisi da samizne rodebi aris meore da mesame parametri
        }
        //s aris sawyisi rod, xolo e aris saboloo rod romelzec struqtura gadagvaq
        //1-dan 3is chatvlit
        static void place_disk(int n, int s, int e)
        {
            if (n == 1)
            {
                print_placements(n, s, e);
            }
            else
            {
                //k aris is rod romelzec n-1 diskiani struqtura gadagvaq
                // 6 raxan yvela matagnis indexis jami 6 aris
                //mashin sawyisis da saboloos garda mesame iqneba
                //samives jams minus mati maji
                int k = 6 - e - s;
                place_disk(n - 1, s, k);
                //gamogvaqs shesabamisi diskebis gadanacvleba
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