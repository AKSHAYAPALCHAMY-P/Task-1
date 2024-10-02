using BookingRoom;

namespace RoomBooking.Test
{
    [TestClass]
    public class UnitTest1
    {
        #region Tests
        [TestMethod]
        public void TestBookRooms_4A_5C()
        {
            string strResult = RoomSeperation.Limitation(4, 5);
            string strEXPECTED = "Room 1: Adults: 1, Children: 3\nRoom 2: Adults: 1, Children: 1\nRoom 3: Adults: 1, Children: 0\nRoom 4: Adults: 1, Children: 0\n";
            Assert.AreEqual(strResult, strEXPECTED);
        }

        [TestMethod]
        public void TestBookRooms_4A_6C()
        {
            string strResult = RoomSeperation.Limitation(4, 6);
            string strEXPECTED = "Room 1: Adults: 1, Children: 3\nRoom 2: Adults: 1, Children: 1\nRoom 3: Adults: 1, Children: 0\nRoom 4: Adults: 1, Children: 0\n";
            Assert.AreEqual(strResult, strEXPECTED);
        }

        [TestMethod]
        public void TestBookRooms_3A_8C()
        {
            string strResult = RoomSeperation.Limitation(3, 8);
            string strEXPECTED = "Room 1: Adults: 1, Children: 3\nRoom 2: Adults: 1, Children: 1\nRoom 3: Adults: 1, Children: 0\nRoom 4: Adults: 0, Children: 0\n";
            Assert.AreEqual(strResult, strEXPECTED);
        }

        [TestMethod]
        public void TestBookRooms_1A_0C()
        {
            string strResult = RoomSeperation.Limitation(1, 0);
            string strEXPECTED = "Room 1: Adults: 1, Children: 0\n";
            Assert.AreEqual(strResult, strEXPECTED);
        }

        [TestMethod]
        public void TestBookRooms_1A_1C()
        {
            string strResult = RoomSeperation.Limitation(1, 1);
            string strEXPECTED = "Room 1: Adults: 1, Children: 1\n";
            Assert.AreEqual(strResult, strEXPECTED);
        }

        [TestMethod]
        public void TestBookRooms_4A_0C()
        {
            string strResult = RoomSeperation.Limitation(4, 0);
            string strEXPECTED = "Room 1: Adults: 1, Children: 0\nRoom 2: Adults: 1, Children: 0\nRoom 3: Adults: 1, Children: 0\nRoom 4: Adults: 1, Children: 0\n";
            Assert.AreEqual(strResult, strEXPECTED);
        }

        [TestMethod]
        public void TestBookRooms_0A_0C()
        {
            string strResult = RoomSeperation.Limitation(0, 0);
            string strEXPECTED = "";
            Assert.AreEqual(strResult, strEXPECTED);
        }
        #endregion

    }
}