using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorromeoIPT101Solution.BorromeoDomain.Models;
using BorromeoIPT101Solution.BorromeoYouTubeViewer.Stores;
using BorromeoIPT101Solution.BorromeoYouTubeViewer.ViewModels;

namespace BorromeoIPT101Solution.BorromeoYouTubeViewer.Commands
{
    public class DeleteYouTubeViewerCommand : AsyncCommandBase
    {
        private readonly YouTubeViewersListingItemViewModel _youTubeViewersListingItemViewModel;
        private readonly YouTubeViewersStore _youTubeViewersStore;

        public DeleteYouTubeViewerCommand(YouTubeViewersListingItemViewModel youTubeViewersListingItemViewModel, YouTubeViewersStore youTubeViewersStore)
        {
            _youTubeViewersListingItemViewModel = youTubeViewersListingItemViewModel;
            _youTubeViewersStore = youTubeViewersStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _youTubeViewersListingItemViewModel.ErrorMessage = null;
            _youTubeViewersListingItemViewModel.IsDeleting = true;

            YouTubeViewer youTubeViewer = _youTubeViewersListingItemViewModel.YouTubeViewer;

            try
            {
                await _youTubeViewersStore.Delete(youTubeViewer.Id);
            }
            catch (Exception)
            {
                _youTubeViewersListingItemViewModel.ErrorMessage = "Failed to delete YouTube viewer. Please try again later.";
            }
            finally
            {
                _youTubeViewersListingItemViewModel.IsDeleting = false;
            }
        }
    }
}
