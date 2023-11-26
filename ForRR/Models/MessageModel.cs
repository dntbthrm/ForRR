using System;
using Avalonia.Media.Imaging;

namespace ForRR.DataModel
{
    public class MessageModel
    {
        public string Name { get; set; } = "Tatiana";
        public Bitmap Photo { get; set; } = new Bitmap("/Users/tatiana/Desktop/images/hihi.png");
        public string MessageText { get; set; } = String.Empty;
    }
}