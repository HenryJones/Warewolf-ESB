using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Dev2.Common;
using Dev2.Communication;
using Dev2.Runtime.ESB.Management.Services;
using Dev2.Services.Security;

namespace Dev2.Runtime.Security
{
    public class ServerSecurityService : SecurityServiceBase
    {
        public const string FileName = "secure.config";

        FileSystemWatcher _configWatcher = new FileSystemWatcher();

        public ServerSecurityService()
            : this(FileName)
        {
        }

        public ServerSecurityService(string fileName)
        {
            InitializeConfigWatcher(fileName);
        }

        protected override List<WindowsGroupPermission> ReadPermissions()
        {
            var reader = new SecurityRead();
            var result = reader.Execute(null, null);
            var serializer = new Dev2JsonSerializer();
            SecuritySettingsTO securitySettingsTO = serializer.Deserialize<SecuritySettingsTO>(result);
            TimeOutPeriod = securitySettingsTO.CacheTimeout;
            return securitySettingsTO.WindowsGroupPermissions;
        }

        protected override void WritePermissions(List<WindowsGroupPermission> permissions)
        {
            SecurityWrite.Write(new SecuritySettingsTO(permissions));
        }

        void InitializeConfigWatcher(string fileName)
        {
            _configWatcher.Path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // Watch for changes in LastAccess and LastWrite times, and the renaming of files or directories. 
            _configWatcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                          | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Only watch secure.config
            _configWatcher.Filter = fileName;

            // Add event handlers.
            _configWatcher.Changed += OnFileChanged;
            _configWatcher.Created += OnFileChanged;
            _configWatcher.Deleted += OnFileChanged;
            _configWatcher.Renamed += OnFileRenamed;

            // Begin watching.
            _configWatcher.EnableRaisingEvents = true;
        }

        protected virtual void OnFileChanged(object sender, FileSystemEventArgs e)
        {
            LogStart();
            OnFileChanged();
            LogEnd();
        }

        protected virtual void OnFileRenamed(object sender, RenamedEventArgs e)
        {
            LogStart();
            OnFileChanged();
            LogEnd();
        }

        void OnFileChanged()
        {
            try
            {
                // Disable raising events otherwise the Changed event is raised twice
                OnFileChangedEnableRaisingEvents(false);
                Read();
            }
            finally
            {
                OnFileChangedEnableRaisingEvents(true);
            }
        }

        protected virtual void OnFileChangedEnableRaisingEvents(bool enabled)
        {
            _configWatcher.EnableRaisingEvents = enabled;
        }

        protected override void OnDisposed()
        {
            if(_configWatcher != null)
            {
                _configWatcher.EnableRaisingEvents = false;
                _configWatcher.Changed -= OnFileChanged;
                _configWatcher.Created -= OnFileChanged;
                _configWatcher.Deleted -= OnFileChanged;
                _configWatcher.Renamed -= OnFileRenamed;
                _configWatcher.Dispose();
                _configWatcher = null;
            }
        }

        protected override void LogStart([CallerMemberName]string methodName = null)
        {
            // ReSharper disable once ExplicitCallerInfoArgument
            ServerLogger.LogDebugStart("SecurityService", methodName);
        }

        protected override void LogEnd([CallerMemberName]string methodName = null)
        {
            // ReSharper disable once ExplicitCallerInfoArgument
            ServerLogger.LogDebugEnd("SecurityService", methodName);
        }
    }
}