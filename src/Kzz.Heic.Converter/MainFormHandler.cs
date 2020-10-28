using ImageMagick;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kzz.Heic.Converter
{
    public class MainFormHandler
    {
        public string SelectFolder()
        {
            var selector = new FolderBrowserDialog();
            selector.ShowDialog();
            return selector.SelectedPath;
        }

        public void ConvertDirectory(string sourcePath, string destinationPath)
        {
            if (!Directory.Exists(sourcePath)) throw new DirectoryNotFoundException($"No se pudo encontrar el directorio de origen {sourcePath}");

            Parallel.ForEach(Directory.GetFiles(sourcePath, "*.heic"), f => {
                var newPath = Path.Combine(destinationPath, f.Replace(Path.GetExtension(f), ".jpg"));
                using MagickImage image = new MagickImage(f);
                image.Write(newPath);
            });


            // Recursively search in subfolders
            string[] folders = Directory.GetDirectories(sourcePath);
            foreach (string folder in folders)
                ConvertDirectory(folder, Path.Combine(destinationPath, folder));
        }
    }
}

