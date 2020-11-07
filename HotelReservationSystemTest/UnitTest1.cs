using HotelReservationSystem;
using NUnit.Framework;
namespace HotelReservationSystemTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void AddHotelTest()
        {
            Hotel hotel = new Hotel(HotelType.BRIDGEWOOD);
            double expectedRate = 150;
            Assert.AreEqual(expectedRate, hotel.RATE);
        }
        [Test]
        public void FindCheapestHotelTest()
        {
            HotelService service = new HotelService();
            HotelType hotel = service.FindCheapestHotel("2018-01-01", "2018-01-03");
            HotelType expected = HotelType.LAKEWOOD;
            Assert.AreEqual(hotel, expected);
        }
    }
}