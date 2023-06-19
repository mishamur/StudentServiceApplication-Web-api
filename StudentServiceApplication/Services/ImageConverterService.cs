using Microsoft.EntityFrameworkCore.Design;
using StudentServiceApplication.Interfaces;
using System.Drawing;

namespace StudentServiceApplication.Services
{
    public class ImageConverterService : IImageConverterService
    {
        public byte[] ConvertImageToByteArray(Image image)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(image, typeof(byte[]));
        }
    }
}