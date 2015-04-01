﻿namespace TowerDefense.Utils
{
    using System;
    using System.IO;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    public static class ImageFactory
    {
        public static ImageSource CreateImage(string fileName)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "..", "..", "images", fileName);
            return new BitmapImage(new Uri(path));
        }
    }
}
