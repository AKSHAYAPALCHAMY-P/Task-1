namespace BookingRoom
{
    public class RoomSeperation
    {
        const int nRooms = 4;
        const int nPersonsAllowed = 4;


        public static string Limitation(int Adult, int Children)
        {
            int nTotal = Adult + Children;
            int nAdults = 0;
            int nChildrens = 0;
            int nCount = 0;
            string strResult = " ";

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
                            strResult+=$"Adult:{nAdults} & Children{nChildrens}";
                        }

                    }
                    nAdults = Adult - nAdults;
                    nChildrens = Children - nChildrens;
                }

            }

            return strResult;
        }
    }
}