using UnitTestingCore.SystemUnderTest.Models;

namespace UnitTestingCore.SystemUnderTest.Services
{
    public interface IParcelService
    {
        Parcel GetParcel(int id);
    }
}