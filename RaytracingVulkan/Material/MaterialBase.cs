using System.Numerics;
using System.Runtime.InteropServices;
using Silk.NET.Maths;

namespace RaytracingVulkan.Material;

[StructLayout(LayoutKind.Sequential)]
public struct MaterialBase
{
    public Vector3 Ambient;
    public float Emissive;
    public float Opacity;
    public float IndexOfRefraction;

    public MaterialBase()
    {
        Ambient = new Vector3(1, 1, 1);
        Emissive = 0.0f;
        Opacity = 1.0f;
        IndexOfRefraction = 0.0f;
    }
}