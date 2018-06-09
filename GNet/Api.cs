using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GNet
{
    public class Api
    {
        // void GNET_API GNet_Startup();
        [DllImport("gnet.dll")]
        public static extern void GNet_Startup();

        // void GNET_API GNet_Shutdown(int block);
        [DllImport("gnet.dll")]
        public static extern void GNet_Shutdown(int block);

        // void GNET_API GNet_Connect(const char* hostname);
        [DllImport("gnet.dll")]
        public static extern void GNet_Connect(StringBuilder hostname);

        // GNet_File* GNET_API GNet_Download(GNet_ID id);
        [DllImport("gnet.dll")]
        public static extern void GNet_Download(byte[] id);

        // GNet_File* GNET_API GNet_Load_File(const char* filename);
        [DllImport("gnet.dll")]
        public static extern IntPtr GNet_Load_File(StringBuilder filename);

        // GNet_File* GNET_API GNet_Load_Data(void* data, unsigned long long length);
        [DllImport("gnet.dll")]
        public static extern IntPtr GNet_Load_Data(IntPtr data, ulong length);

        // void GNET_API GNet_Free_File(GNet_File* file);
        [DllImport("gnet.dll")]
        public static extern IntPtr GNet_Free_File(IntPtr file);

        // void GNET_API GNet_Upload(GNet_File* file);
        [DllImport("gnet.dll")]
        public static extern IntPtr GNet_Upload(IntPtr file);
    }
}