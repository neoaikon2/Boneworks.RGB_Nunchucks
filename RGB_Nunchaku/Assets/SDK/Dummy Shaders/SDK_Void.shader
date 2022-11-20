Shader "SDK/Void" { // SLZ/Void
	Properties {
		_OffsetDistance ("Offset Distance", Vector) = (1,0,0,0)
		_TextureScaling ("Texture Scaling", Float) = 1
		[NoScaleOffset] _BackgroundTexture ("Background Texture", 2D) = "white" {}
		_DistortBackground ("Distort Background", Float) = 0.1
		_DistortEmission ("Distort Emission", Float) = 0.1
		_Emission ("Emission", 2D) = "white" {}
		[HDR] _EmissionColor ("EmissionColor", Vector) = (0,0,0,0)
		_Distortion ("Distortion", 2D) = "white" {}
		_BRDFLUT ("BRDFLUT", 2D) = "white" {}
		_CloneTransparency ("Cloned Transparency", Range(0, 1)) = 0.5
		_CloneTransparencyStart ("Start Transparency", Range(0, 1)) = 1
		[HideInInspector] _texcoord ("", 2D) = "white" {}
	}
	SubShader
    {
        Tags { "RenderType" = "Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        half _Glossiness;
        half _Metallic;
        fixed4 _Color;

        // Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
        // See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
        // #pragma instancing_options assumeuniformscaling
        UNITY_INSTANCING_BUFFER_START(Props)
            // put more per-instance properties here
        UNITY_INSTANCING_BUFFER_END(Props)

        void surf(Input IN, inout SurfaceOutputStandard o)
        {
            // Albedo comes from a texture tinted by color
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
            o.Albedo = c.rgb;
            // Metallic and smoothness come from slider variables
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            o.Alpha = c.a;
        }
        ENDCG
    }
}