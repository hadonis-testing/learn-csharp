namespace CS07
{
    internal class Program
    {
        public static void PrintDriveInfo()
        {
            var drivesInfo = DriveInfo.GetDrives();


            foreach (var item in drivesInfo)
            {
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Type: {item.DriveType}");
                Console.WriteLine($"Label: {item.VolumeLabel}");
                Console.WriteLine($"Format: {item.DriveFormat}");
                Console.WriteLine($"Total: {item.TotalSize / 1000000000} GB");
                Console.WriteLine($"Free: {item.TotalFreeSpace / 1000000000} GB");
                Console.WriteLine();
            }
        }

        public static void PrintDirectoryInfo(string path)
        {
            var directoryInfo = new DirectoryInfo(path);

            Console.WriteLine($"Name: {directoryInfo.Name}");
            Console.WriteLine($"Full Name: {directoryInfo.FullName}");
            Console.WriteLine($"Parent: {directoryInfo.Parent}");
            Console.WriteLine($"Root: {directoryInfo.Root}");
            Console.WriteLine($"Creation Time: {directoryInfo.CreationTime}");
            Console.WriteLine($"Last Access Time: {directoryInfo.LastAccessTime}");
            Console.WriteLine($"Last Write Time: {directoryInfo.LastWriteTime}");
            Console.WriteLine($"Attributes: {directoryInfo.Attributes}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            PrintDriveInfo();

            PrintDirectoryInfo(@"D:\Project");
        }
    }
}
