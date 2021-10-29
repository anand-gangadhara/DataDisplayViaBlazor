using System.IO;

namespace DisplayData.Wrappers
{
    public interface IFileIO
    {
        FileStream Open(string filePath, FileMode open);
    }
}