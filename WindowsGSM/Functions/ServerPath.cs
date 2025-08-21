using System.IO;

namespace WindowsGSM.Functions
{
    public static class ServerPath
    {
        public static class FolderName
        {
            public const string Bin = "bin";
            public const string Backups = "backups";
            public const string Installer = "installer";
            public const string Logs = "logs";
            public const string Plugins = "plugins";
            public const string Servers = "servers";
            public const string Configs = "configs";
            public const string Cache = "cache";
            public const string Serverfiles = "serverfiles";
        }

        public static void CreateAndFixDirectories()
        {
            Directory.CreateDirectory(Get(FolderName.Backups));
            Directory.CreateDirectory(Get(FolderName.Bin));
            Directory.CreateDirectory(Get(FolderName.Configs));
            Directory.CreateDirectory(Get(FolderName.Logs));
            Directory.CreateDirectory(Get(FolderName.Plugins));
            Directory.CreateDirectory(Get(FolderName.Servers));
        }

        /// <summary>
        /// Get WindowsGSM.exe parent directory path. Example: "C://WindowsGSM/"
        /// </summary>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        /// <param name="path3"></param>
        /// <returns></returns>
        public static string Get(string path1 = "", string path2 = "", string path3 = "")
        {
            return Path.Combine(MainWindow.WGSM_PATH, path1, path2, path3);
        }

        /// <summary>
        /// Get backup directory path with serverId. Example: "C://WindowsGSM/backups/1/"
        /// </summary>
        /// <param name="serverId"></param>
        /// <returns></returns>
        public static string GetBackups(string serverId)
        {
            var backupConfig = new BackupConfig(serverId);
            if (Directory.Exists(backupConfig.BackupLocation))
            {
                return backupConfig.BackupLocation;
            }

            string defaultBackupPath = Path.Combine(MainWindow.WGSM_PATH, FolderName.Backups, serverId);
            Directory.CreateDirectory(defaultBackupPath);
            return defaultBackupPath;
        }

        /// <summary>
        /// Get bin directory path. Example: "C://WindowsGSM/bin/"
        /// </summary>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        /// <param name="path3"></param>
        /// <returns></returns>
        public static string GetBin(string path1 = "", string path2 = "", string path3 = "")
        {
            return Path.Combine(MainWindow.WGSM_PATH, FolderName.Bin, path1, path2, path3);
        }

        public static string GetInstaller(string path = "") // Unused
        {
            return Path.Combine(MainWindow.WGSM_PATH, FolderName.Installer, path);
        }

        /// <summary>
        /// Get log directory path. Example: "C://WindowsGSM/logs/"
        /// </summary>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        /// <param name="path3"></param>
        /// <returns></returns>
        public static string GetLogs(string path1 = "", string path2 = "", string path3 = "")
        {
            return Path.Combine(MainWindow.WGSM_PATH, FolderName.Logs, path1, path2, path3);
        }

        /// <summary>
        /// Get plugins directory path. Example: "C://WindowsGSM/plugins/"
        /// </summary>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        /// <param name="path3"></param>
        /// <returns></returns>
        public static string GetPlugins(string path1 = "", string path2 = "", string path3 = "")
        {
            return Path.Combine(MainWindow.WGSM_PATH, FolderName.Plugins, path1, path2, path3);
        }

        /// <summary>
        /// Get servers directory path with serverId. Example: "C://WindowsGSM/servers/1/"
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        /// <returns></returns>
        public static string GetServers(string serverId, string path1 = "", string path2 = "")
        {
            return Path.Combine(MainWindow.WGSM_PATH, FolderName.Servers, serverId, path1, path2);
        }

        /// <summary>
        /// Get servers configs directory path with serverId. Example: "C://WindowsGSM/servers/1/configs/"
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        /// <returns></returns>
        public static string GetServersConfigs(string serverId, string path1 = "", string path2 = "")
        {
            return Path.Combine(GetServers(serverId), FolderName.Configs, path1, path2);
        }

        /// <summary>
        /// Get servers cache directory path with serverId. Example: "C://WindowsGSM/servers/1/cache/"
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        /// <returns></returns>
        public static string GetServersCache(string serverId, string path1 = "", string path2 = "")
        {
            return Path.Combine(GetServers(serverId), FolderName.Cache, path1, path2);
        }

        /// <summary>
        /// Get serverfiles directory path with serverId. Example: "C://WindowsGSM/servers/1/serverfiles/"
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        /// <param name="path3"></param>
        /// <returns></returns>
        public static string GetServersServerFiles(string serverId, string path1 = "", string path2 = "", string path3 = "")
        {
            return Path.Combine(GetServers(serverId), FolderName.Serverfiles, path1, path2, path3);
        }
    }
}
