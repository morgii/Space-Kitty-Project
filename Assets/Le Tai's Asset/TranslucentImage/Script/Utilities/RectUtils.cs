using UnityEngine;

namespace LeTai.Asset.TranslucentImage
{
public static class RectUtils
{
    /// <summary>
    /// Fast approximate equal for rect position and size in range [0,1]
    /// </summary>
    internal static bool ApproximateEqual01(Rect a, Rect b)
    {
        return QuickApproximate01(a.x,      b.x)
            && QuickApproximate01(a.y,      b.y)
            && QuickApproximate01(a.width,  b.width)
            && QuickApproximate01(a.height, b.height);
    }


    private static bool QuickApproximate01(float a, float b)
    {
        const float epsilon01 = 5.9604644e-8f; // different between 1 and largest float < 1
        return Mathf.Abs(b - a) < epsilon01;
    }

    public static Vector4 ToMinMaxVector(Rect rect)
    {
        return new Vector4(
            rect.xMin,
            rect.yMin,
            rect.xMax,
            rect.yMax
        );
    }

    public static Vector4 ToVector4(Rect rect)
    {
        return new Vector4(
            rect.xMin,
            rect.yMin,
            rect.width,
            rect.height
        );
    }
}
}
