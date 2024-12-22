namespace Proxy
{
    public class FileAccessProxy : IFileAccess
    {
        private FileAccessor _fileAccessor;
        private string _userRole;

        public FileAccessProxy(string userRole)
        {
            _userRole = userRole;
        }

        public void ReadFile(string fileName)
        {
            if (HasAccess())
            {
                Console.WriteLine("FileAccessProxy: Access granted.");
                _fileAccessor ??= new FileAccessor();
                _fileAccessor.ReadFile(fileName);
            }
            else
            {
                Console.WriteLine("FileAccessProxy: Access denied. Insufficient permissions.");
            }
        }

        private bool HasAccess()
        {
            return _userRole == "Admin";
        }
    }
}