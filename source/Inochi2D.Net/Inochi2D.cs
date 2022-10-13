using System.Runtime.InteropServices;

namespace Inochi2D.Net
{
    public class Inochi2D
    {
        internal const string LIB_NAME = "inochi2d-c";

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double I2DTimingFuncSignature();
        
        /// <summary>
        /// Initializes Inochi2D
        /// </summary>
        [DllImport(LIB_NAME)]
        public static extern void inInit([MarshalAs(UnmanagedType.FunctionPtr)] I2DTimingFuncSignature func);
        
        /// <summary>
        /// Updates the Inochi2D timing systems
        /// </summary>
        [DllImport(LIB_NAME)]
        public static extern void inUpdate();
        
        /// <summary>
        /// Uninitializes Inochi2D and cleans up everything
        /// </summary>
        [DllImport(LIB_NAME)]
        public static extern void inCleanup();
        
        /// <summary>
        /// Sets viewport
        /// </summary>
        [DllImport(LIB_NAME)]
        public static extern void inViewportSet(int width, int height);
        
        /// <summary>
        /// Gets viewport size
        /// </summary>
        [DllImport(LIB_NAME)]
        public static extern void inViewportGet(ref int width, ref int height);

#if YES_GL
        
        /// <summary>
        /// Begins a scene render
        /// </summary>
        [DllImport(LIB_NAME)]
        public static extern void inSceneBegin();
        
        /// <summary>
        /// Ends a scene render
        /// </summary>
        [DllImport(LIB_NAME)]
        public static extern void inSceneEnd();
        
        /// <summary>
        /// Draws Inochi2D scene
        /// </summary>
        [DllImport(LIB_NAME)]
        public static extern void inSceneDraw(float x, float y, float width, float height);
#endif
      
        /// <summary>
        /// Runs function in a protected block that catches D exceptions.
        /// </summary>
        [DllImport(LIB_NAME)]
        public static extern void inBlockProtected([MarshalAs(UnmanagedType.FunctionPtr)] function func);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void function();
    }
}