using System.Numerics;
using System.Runtime.InteropServices;
using static Inochi2D.Net.Inochi2D;
namespace Inochi2D.Net.Camera;

public struct InCamera
{
    /// <summary>
    /// Gets the current camera
    /// </summary>
    [DllImport(LIB_NAME)]
    public static extern ref InCamera inCameraGetCurrent();

    /// <summary>
    /// Sets the position of a camera
    /// </summary>
    [DllImport(LIB_NAME)]
    public static extern void inCameraSetPosition(ref InCamera camera, float x, float y);

    /// <summary>
    /// Gets the position of a camera
    /// </summary>
    [DllImport(LIB_NAME)]
    public static extern void inCameraGetPosition(ref InCamera camera, ref float x, ref float y);

    /// <summary>
    /// Sets the zoom of a camera
    /// </summary>
    [DllImport(LIB_NAME)]
    public static extern void inCameraSetZoom(ref InCamera camera, float zoom);
    
    /// <summary>
    /// Gets the zoom of a camera
    /// </summary>
    [DllImport(LIB_NAME)]
    public static extern void inCameraGetZoom(ref InCamera camera, ref float zoom);

    /// <summary>
    /// Gets the zoom of a camera
    /// </summary>
    [DllImport(LIB_NAME)]
    public static extern void inCameraGetCenterOffset(ref InCamera camera, ref float x, ref float y);

    /// <summary>
    /// Gets the "real size" from the camera
    /// </summary>
    [DllImport(LIB_NAME)]
    public static extern void inCameraGetRealSize(ref InCamera camera, ref float x, ref float y);
    
    /// <summary>
    /// Copies the values of the internal camera matrix out to mat4
    /// </summary>
    [DllImport(LIB_NAME)]
    public static extern void inCameraGetMatrix(ref InCamera camera, ref Matrix4x4 mat4);
        
    /// <summary>
    /// Destroys a camera
    /// </summary>
    [DllImport(LIB_NAME)]
    public static extern void inCameraDestroy(ref InCamera camera);
}