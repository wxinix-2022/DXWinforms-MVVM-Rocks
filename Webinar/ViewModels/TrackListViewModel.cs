using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Webinar.Data;

namespace Webinar.ViewModels
{
    [POCOViewModel]
    public sealed class TrackListViewModel
    {
        public TrackList Tracks { get; set; }
        public TrackInfo SelectedTrack { get; set; }

        private TrackListViewModel()
        {
            Tracks = new TrackList();
        }

        public static TrackListViewModel Create()
        {
            return ViewModelSource.Create(() => new TrackListViewModel());
        }

        [ServiceProperty(SearchMode = ServiceSearchMode.PreferParents)]
        private static IDocumentManagerService DocumentManagerService => null;

        public void EditTrack(object trackObject)
        {
            var track = trackObject as TrackInfo;
            var document = DocumentManagerService.CreateDocument("TrackView", TrackViewModel.Create(track));
            document.Show();
        }
    }
}