Shader "SDK/Laser" { // SLZ/Laser
	Properties {
		_LaserVector3 ("_LaserVector3", Vector) = (0,0,1,0)
		_Tiling ("Tiling", Float) = 1
		_Noise ("Noise", 2D) = "gray" {}
		[HDR] _Color ("Color", Vector) = (0,1,0,0)
		_3dNoise ("3dNoise", 3D) = "white" {}
		_uniformfog ("uniformfog", Range(0, 1)) = 0
		_Intensity ("Intensity", Float) = 1
		_OffsetFactor ("Offset Factor", Float) = 0
		_OffsetUnits ("Offset Units", Float) = 0
		_MinIntensitiy ("Min Intensitiy", Range(0, 1)) = 0.1
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
	CustomEditor "ASEMaterialInspector"
}