using System.Collections.Generic;
using System.ComponentModel;
using Avalonia.Media.Imaging;
using System.IO;
using ReactiveUI;


namespace ForRR.ViewModels
{

    public class ImageReaderViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private string _dirPath;
        private List<Bitmap> _photos = new List<Bitmap>();
        
        public string DirPath
        {
            get => _dirPath;
            set => this.RaiseAndSetIfChanged(ref _dirPath, value);
        }

        public List<Bitmap> Photos
        {
            get => _photos;
            set => this.RaiseAndSetIfChanged(ref _photos, value);
        }
        public void GetPhotos()
        {
            var imgPaths = Directory.GetFiles(DirPath, "*.png");
            
            List<Bitmap> ph = new List<Bitmap>();
            foreach (var path in imgPaths)
            {
                var bitmap = new Bitmap(path);
                ph.Add(bitmap);
            }
            
            Photos = ph;
        }
        public ImageReaderViewModel() {}
    }
}