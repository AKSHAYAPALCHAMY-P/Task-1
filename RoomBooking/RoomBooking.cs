namespace BookingRoom
{
    public class RoomSeperation
    {
        const int nRooms = 4;
        const int nPersonsAllowed = 4;
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Adults:");
            bool nAdults = int.TryParse(Console.ReadLine(), out int Adult);

            Console.WriteLine("Enter the Number of Childrens:");
            bool nChildrens = int.TryParse(Console.ReadLine(), out int Children);

            //Constraints => 4 guests  allowed and 1 Adult,16 peoples
            //are allowed,limitation=>4 rooms

            Limtation(Adult, Children);

        }


        public static void Limtation(int Adult, int Children)
        {
            int nTotal = Adult + Children;
            int nAdults = 0;
            int nChildrens = 0;
            int nCount = 0;

            while (nCount != nPersonsAllowed)
            {
                if (nTotal <= 16 && nRooms <= 4 && Adult != 0)
                {

                    for (int i = 0; i < nRooms; i++)
                    {
                        nAdults++;
                        nChildrens++;

                        nCount = nChildrens + nAdults;

                        if (nCount == nPersonsAllowed)
                        {
                            Console.WriteLine($"Adult:{nAdults} & Children{nChildrens}");
                        }

                    }
                    nAdults = Adult - nAdults;
                    nChildrens = Children - nChildrens;
                }
                    
                }
            }

        }
    }


