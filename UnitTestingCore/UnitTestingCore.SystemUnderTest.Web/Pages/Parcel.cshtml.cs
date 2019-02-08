using Microsoft.AspNetCore.Mvc.RazorPages;
using UnitTestingCore.SystemUnderTest.Services;

namespace UnitTestingCore.SystemUnderTest.Web.Pages
{
    public class ParcelModel : PageModel
    {
        private readonly IParcelService _parcelSvc;

        public string Name { get; set; }
        public string Township { get; set; }
        public string Owner { get; set; }

        public ParcelModel(IParcelService parcelService)
        {
            _parcelSvc = parcelService;
        }
        public void OnGet()
        {
            var parcel = _parcelSvc.GetParcel(1);

            Name = parcel.Name;
            Township = parcel.Township;
            Owner = parcel.Owner;

        }
    }
}