namespace DataStructure.Recursion
{
    public class TowerOfHenoi
    {
        public string Source = "Source";
        public string Destination = "Destination";
        public string Helper = "Helper";

        public TowerOfHenoi(int numberOfDisk)
        {
            TowerOfHenoiRecurssion(numberOfDisk, Source, Helper, Destination);


            //Iterative
            Console.Write("Enter number of disks: ");
            int n = int.Parse(Console.ReadLine());
            TowerOfHanoiIterative(n, 'A', 'C', 'B');
        }

        public void TowerOfHenoiRecurssion(int disk, string source, string helper, string destination)
        {
            if (disk == 1)
                Console.WriteLine($"Transfer the disk {disk} from {source} to {destination}");

            TowerOfHenoiRecurssion(disk - 1, source, destination, helper);
            Console.WriteLine($"Transfer the disk {disk} from {source} to {destination}");
            TowerOfHenoiRecurssion(disk - 1, helper, source, destination);

        }

        static void TowerOfHanoiIterative(int n, char source, char target, char auxiliary)
        {
            int totalMoves = (int)Math.Pow(2, n) - 1;

            // Swap target and auxiliary for even disks
            if (n % 2 == 0)
            {
                char temp = target;
                target = auxiliary;
                auxiliary = temp;
            }

            for (int move = 1; move <= totalMoves; move++)
            {
                if (move % 3 == 1)
                    MoveDisk(source, target);
                else if (move % 3 == 2)
                    MoveDisk(source, auxiliary);
                else if (move % 3 == 0)
                    MoveDisk(auxiliary, target);
            }

        }

        static void MoveDisk(char from, char to)
        {
            Console.WriteLine($"Move disk from {from} to {to}");
        }
    }
}
