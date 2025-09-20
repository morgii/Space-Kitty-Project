float2 UnCropUV(float2 uvRelativeToCropped, float4 cropRegion)
{
    return lerp(cropRegion.xy, cropRegion.zw, uvRelativeToCropped);
}

float2 CropUV(float2 uvRelativeToUnCropped, float4 cropRegion)
{
    return (uvRelativeToUnCropped - cropRegion.xy) / (cropRegion.zw - cropRegion.xy);
}
