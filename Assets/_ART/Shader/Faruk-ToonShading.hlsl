void ToonShading_float(
    in float3 Normal,
    in float ToonRampSmoothness,
    in float3 ClipSpacePos,
    in float3 WorldPos,
    in float4 ToonRampTinting,  // Tinting rengi RGBA
    in float ToonRampOffset,
    out float3 ToonRampOutput,
    out float3 Direction)
{
    #ifdef SHADERGRAPH_PREVIEW
        ToonRampOutput = float3(0.5, 0.5, 0); // Sadece önizleme için sabit renk
        Direction = float3(0.5, 0.5, 0);
    #else
        half4 shadowCoord;

        #if SHADOWS_SCREEN
            shadowCoord = ComputeScreenPos(float4(ClipSpacePos, 1.0));
        #else
            shadowCoord = TransformWorldToShadowCoord(WorldPos);
        #endif

        Light light;

        #if _MAIN_LIGHT_SHADOWS_CASCADE || _MAIN_LIGHT_SHADOWS
            light = GetMainLight(shadowCoord);
        #else
            light = GetMainLight();
        #endif

        // Işık yönü ile normal arasındaki açının toon'lanması
        half NdotL = dot(Normal, light.direction) * 0.5 + 0.5;
        half toonRamp = smoothstep(ToonRampOffset, ToonRampOffset + ToonRampSmoothness, NdotL);

        // Gölge etkisi ekleniyor
        toonRamp *= light.shadowAttenuation;

        // Sonuç renk hesaplama, sadece RGB kısmını kullanıyoruz
        float3 lightColor = light.color.rgb;
        float3 tintColor = ToonRampTinting.rgb;

        ToonRampOutput = lightColor * (toonRamp + tintColor);
        Direction = light.direction;
    #endif
}
