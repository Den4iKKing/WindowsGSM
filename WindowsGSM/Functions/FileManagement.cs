using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace WindowsGSM.Functions
{
    public static class FileManagement
    {
        /// <summary>
        /// Extract .zip file async
        /// </summary>
        /// <param name="sourceArchiveFileName"></param>
        /// <param name="destinationDirectoryName"></param>
        /// <returns></returns>
        public static async Task<bool> ExtractZip(string sourceArchiveFileName, string destinationDirectoryName)
        {
            return await Task.Run(() =>
            {
                try
                {
                    ZipFile.ExtractToDirectory(sourceArchiveFileName, destinationDirectoryName);
                    return true;
                }
                catch
                {
                    return false;
                }
            });
        }

        /// <summary>
        /// Delete file async
        /// </summary>
        /// <param name="sourceArchiveFileName"></param>
        /// <param name="destinationDirectoryName"></param>
        /// <returns></returns>
        public static async Task<bool> DeleteAsync(string path)
        {
            return await Task.Run(() =>
            {
                try
                {
                    File.Delete(path);
                    return true;
                }
                catch
                {
                    return false;
                }
            });
        }
    }
}
