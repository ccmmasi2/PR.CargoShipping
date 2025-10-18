using PR.CargoShipping.Service.ViewModels;

namespace PR.CargoShipping.Service
{
    public interface ITripSegmentService
    {
        List<TripSegmentViewModel> GetTripSegmentsByTripNumber(string tripNumber);
    }
}
