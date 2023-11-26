using System;
using System.ComponentModel;
using System.Net;
using System.Threading.Tasks;
using Avalonia.Media.Imaging;
using ReactiveUI;


namespace ForRR.ViewModels
{

    public class ImageLoaderViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private string _imageLink;
        private Bitmap _imgSource;

        public string ImageLink
        {
            get => _imageLink;
            set => this.RaiseAndSetIfChanged(ref _imageLink, value);
        }

        public Bitmap ImgSource
        {
            get => _imgSource;
            set => this.RaiseAndSetIfChanged(ref _imgSource, value);
        }

        public async Task LoadFromWeb()
        {
            if (ImageLink != null && ImageLink != " ")
            {
                using (var webClient = new WebClient())
                {
                    byte[] data = await webClient.DownloadDataTaskAsync(new Uri(ImageLink));
                    ImgSource = new Bitmap(new System.IO.MemoryStream(data));
                }
            }
        }
        public ImageLoaderViewModel()
        {
        }
    }
}