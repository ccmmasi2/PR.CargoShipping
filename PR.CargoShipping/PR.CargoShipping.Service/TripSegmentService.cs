using PR.CargoShipping.Repository;
using PR.CargoShipping.Service.ViewModels;

namespace PR.CargoShipping.Service
{
    public class TripSegmentService : ITripSegmentService
    {
        private ITripSegmentRepository tripSegmentRepository;

        public TripSegmentService(ITripSegmentRepository tripSegmentRepository)
        {
            this.tripSegmentRepository = tripSegmentRepository;
        }

        public List<TripSegmentViewModel> GetTripSegmentsByTripNumber(string tripNumber)
        {
            var listSegments = tripSegmentRepository.GetTripSegmentsByTripNumber(tripNumber);

            if (listSegments == null || listSegments.Count <= 0) return new List<TripSegmentViewModel>();

            return listSegments.Select(x =>
            {
                decimal? actualHours = null;
                decimal? sailingVariance = null;
                bool warning = false;

                if (x.StartDateTime.HasValue && x.EndDateTime.HasValue)
                {
                    actualHours = (x.EndDateTime - x.StartDateTime).Value.Hours;

                    if (actualHours.HasValue && actualHours < 0)
                        throw new ApplicationException($"Segment start time and end time of trip {tripNumber} are incorrect");

                    sailingVariance = actualHours - x.StandardHours;

                    if (sailingVariance.HasValue && sailingVariance / x.StandardHours > (decimal)0.1)
                        warning = true;
                }

                return new TripSegmentViewModel
                {
                    TripNumber = x.TripNumber,
                    StartPort = x.StartPort,
                    EndPort = x.EndPort,
                    StandardHours = x.StandardHours,
                    SailingSequence = x.SailingSequence,
                    ActualHours = actualHours,
                    StartDateTime = x.StartDateTime?.ToString("MM/dd/yyyy hh:mm tt") ?? string.Empty,
                    EndDateTime = x.EndDateTime?.ToString("MM/dd/yyyy hh:mm tt") ?? string.Empty,
                    VarianceWarning = warning
                };
            }).ToList();
        }
    }
}
