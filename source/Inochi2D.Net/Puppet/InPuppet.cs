using System;
using System.Runtime.InteropServices;
using static Inochi2D.Net.Inochi2D;
namespace Inochi2D.Net.Puppet;

public struct InPuppet
{
    /// <summary>
    /// Loads a puppet from path
    /// </summary>
    [DllImport(LIB_NAME)]
    public static extern ref InPuppet inPuppetLoad(Span<char> path);
    
    /// <summary>
    /// Loads a puppet from path (length denominated string)
    /// </summary>
    [DllImport(LIB_NAME)]
    public static extern ref InPuppet inPuppetLoadEx(Span<char> path, nint length);

    /// <summary>
    /// Loads a puppet from memory
    /// </summary>
    [DllImport(LIB_NAME)]
    public static extern ref InPuppet inPuppetLoadFromMemory(ref Span<byte> data, nint length);
    
    /// <summary>
    /// Destroys a puppet and unloads its
    /// </summary>
    [DllImport(LIB_NAME)]
    public static extern void inPuppetDestroy(ref InPuppet puppet);

    /// <summary>
    /// Gets the name of a puppet (as written in metadata)
    /// </summary>
    [DllImport(LIB_NAME)]
    public static extern void inPuppetGetName(ref InPuppet puppet, ref Span<char> stuff, ref nint len);
    
    /// <summary>
    /// Update puppet
    /// </summary>
    [DllImport(LIB_NAME)]
    public static extern void inPuppetUpdate(ref InPuppet puppet);
    
#if YES_GL
    
    /// <summary>
    /// Draw puppet
    /// </summary>
    [DllImport(LIB_NAME)]
    public static extern void inPuppetDraw(ref InPuppet puppet);
#endif
}