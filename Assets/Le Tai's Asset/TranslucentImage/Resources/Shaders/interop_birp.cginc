#include <UnityCG.cginc>

// This need to be a macro since the type of tex can change :(
#define SAMPLE_SCREEN_TEX(tex, uv) UNITY_SAMPLE_SCREENSPACE_TEXTURE(tex, UnityStereoTransformScreenSpaceTex(uv))
