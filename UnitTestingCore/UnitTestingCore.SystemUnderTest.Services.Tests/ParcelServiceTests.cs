using Xunit;

namespace UnitTestingCore.SystemUnderTest.Services.Tests
{
    public class ParcelServiceTests
    {
        [Fact]
        public void ParcelService_GetParcel_Verify()
        {
            //arrange
            var parcelSvc = new ParcelService();

            //act
            var parcel = parcelSvc.GetParcel(1);

            //assert
            Assert.True(1 == parcel.Id, "Ids don't match");
        }
    }
}
