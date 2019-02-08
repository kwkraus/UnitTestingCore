using UnitTestingCore.SystemUnderTest.Models;

namespace UnitTestingCore.SystemUnderTest.Services
{
    public class ParcelService : IParcelService
    {
        public Parcel GetParcel(int id)
        {
            return new Parcel
            {
                Id = id,
                Name = "Kevin Center",
                Township = "Parker",
                Owner = "Douglas County"
            };
        }
    }
}
