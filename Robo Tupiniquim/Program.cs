namespace Robo_Tupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int maxX = int.Parse(input[0]);
            int maxY = int.Parse(input[1]);

            while (true)
            {
                string positionInput = Console.ReadLine();
                if (string.IsNullOrEmpty(positionInput)) break;

                string[] positionParts = positionInput.Split(' ');

                int x = int.Parse(positionParts[0]);
                int y = int.Parse(positionParts[1]);
                char orientation = positionParts[2][0];

                string instructions = Console.ReadLine();

                foreach (char instruction in instructions)
                {
                    switch (instruction)
                    {
                        case 'M':
                            switch (orientation)
                            {
                                case 'N':
                                    if (y < maxY) y++;
                                    break;
                                case 'S':
                                    if (y > 0) y--;
                                    break;
                                case 'L':
                                    if (x < maxX) x++;
                                    break;
                                case 'O':
                                    if (x > 0) x--;
                                    break;
                            }
                            break;
                        case 'E':
                            switch (orientation)
                            {
                                case 'N':
                                    orientation = 'O';
                                    break;
                                case 'S':
                                    orientation = 'L';
                                    break;
                                case 'L':
                                    orientation = 'N';
                                    break;
                                case 'O':
                                    orientation = 'S';
                                    break;
                            }
                            break;
                        case 'D':
                            switch (orientation)
                            {
                                case 'N':
                                    orientation = 'L';
                                    break;
                                case 'S':
                                    orientation = 'O';
                                    break;
                                case 'L':
                                    orientation = 'S';
                                    break;
                                case 'O':
                                    orientation = 'N';
                                    break;
                            }
                            break;
                    }
                }

                Console.WriteLine($"{x} {y} {orientation}");
            }
        }
    }
}