//namespace RoomBooking.Logic
//{
//    public class RoomSeperation
//    {
//        const int nRooms = 4;
//        const int nPersonsAllowed = 4;
//        const int nMaxTotalPersons = 16;

//        public static string Limitation(int nAdults, int nChildren)
//        {
//            int nTotal = nAdults + nChildren;
//            if (nTotal > nMaxTotalPersons)
//            {
//                return "Exceeded maximum total persons allowed.";
//            }

//            int nAssignedRooms = 0;
//            string result = "";

//            while (nAssignedRooms < nRooms && (nAdults > 0 || nChildren > 0))
//            {
//                int nAdultsInRoom = 0;
//                int nChildrensInRoom = 0;


//                while (nAdultsInRoom < nPersonsAllowed && nAdults > 0)
//                {
//                    nAdultsInRoom++;
//                    nAdults--;
//                }


//                int remainingCapacity = nPersonsAllowed - nAdultsInRoom;


//                while (nChildrensInRoom < remainingCapacity && nChildren > 0)
//                {
//                    nChildrensInRoom++;
//                    nChildren--;
//                }

//                nAssignedRooms++;
//                result += $"Room {nAssignedRooms}: Adults: {nAdultsInRoom}, Children: {nChildrensInRoom}\n";
//            }

//            return result;
//        }
//    }
//}
