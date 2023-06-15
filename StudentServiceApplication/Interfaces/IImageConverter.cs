using System.Drawing;

namespace StudentServiceApplication.Interfaces
{
    public interface IImageConverterService
    {
        public byte[] ConvertImageToByteArray(Image image);
    }
}
