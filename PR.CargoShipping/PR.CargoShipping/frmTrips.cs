using PR.CargoShipping.Service;
using PR.CargoShipping.Service.ViewModels;

namespace PR.CargoShipping
{
    public partial class frmTrips : Form
    {
        private ITripSegmentService tripSegmentService;

        public frmTrips(ITripSegmentService tripSegmentService)
        {
            InitializeComponent();

            this.tripSegmentService = tripSegmentService;
        }

        private void btnSearchByTripNumber_Click(object sender, EventArgs e)
        {
            var segments = tripSegmentService.GetTripSegmentsByTripNumber(txtTripNumber.Text);
            gvTrips.DataSource = segments;
        }

        private void gvTrips_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (!gvTrips.Columns.Contains("Warning"))
            {
                var warningColumn = new DataGridViewButtonColumn
                {
                    Text = "Warning",
                    Name = "Warning",
                    Width = 140
                };
                gvTrips.Columns.Add(warningColumn);
            }

            if (gvTrips.Columns.Contains("VarianceWarning"))
            {
                gvTrips.Columns.Remove("VarianceWarning");
            }
        }

        private void gvTrips_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var segments = gvTrips.DataSource as List<TripSegmentViewModel>;
            if (e.RowIndex < 0 || e.RowIndex >= segments.Count) return;

            if (segments[e.RowIndex].VarianceWarning)
            {
                if (e.ColumnIndex >= 0 && gvTrips.Columns[e.ColumnIndex].Name == "Warning" && e.RowIndex >= 0)
                { 
                }
            }
        }
    }
}
