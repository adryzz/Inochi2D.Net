using System.Runtime.InteropServices;
using static Inochi2D.Net.Inochi2D;

namespace Inochi2D.Net.Err
{
    
    /// <summary>
    /// An Inochi2D error
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct InError
    {
        [MarshalAs(UnmanagedType.LPWStr)]
        public string msg;
        
        [DllImport(LIB_NAME)]
        public static extern InError inErrorGet();
    }
}