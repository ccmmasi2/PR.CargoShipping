using PR.CargoShipping.Domain;

namespace PR.CargoShipping.Repository
{
    public interface ITripSegmentRepository
    {
        List<TripSegment> GetTripSegmentsByTripNumber(string tripNumber);
    }
}
