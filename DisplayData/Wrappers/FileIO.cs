using System.IO;

namespace DisplayData.Wrappers
{
    public class FileIO : IFileIO
    {
        public FileStream Open(string filePath, FileMode open)
        {
            return File.Open(filePath, open);
        }
    }
}
