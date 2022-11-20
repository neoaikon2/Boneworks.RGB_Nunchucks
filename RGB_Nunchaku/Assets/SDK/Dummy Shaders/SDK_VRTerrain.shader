Shader "SDK/VRTerrain" { // SLZ/VR Terrain
	Properties {
		[HideInInspector] _Control ("Control", 2D) = "white" {}
		[HideInInspector] _Splat3 ("Splat3", 2D) = "white" {}
		[HideInInspector] _Splat2 ("Splat2", 2D) = "white" {}
		[HideInInspector] _Splat1 ("Splat1", 2D) = "white" {}
		[HideInInspector] _Splat0 ("Splat0", 2D) = "white" {}
		[HideInInspector] _Normal0 ("Normal0", 2D) = "white" {}
		[HideInInspector] _Normal1 ("Normal1", 2D) = "white" {}
		[HideInInspector] _Normal2 ("Normal2", 2D) = "white" {}
		[HideInInspector] _Normal3 ("Normal3", 2D) = "white" {}
		[HideInInspector] _Smoothness3 ("Smoothness3", Range(0, 1)) = 1
		[HideInInspector] _Smoothness1 ("Smoothness1", Range(0, 1)) = 1
		[HideInInspector] _Smoothness0 ("Smoothness0", Range(0, 1)) = 1
		[HideInInspector] _Smoothness2 ("Smoothness2", Range(0, 1)) = 1
		[HideInInspector] [Gamma] _Metallic0 ("Metallic0", Range(0, 1)) = 0
		[HideInInspector] [Gamma] _Metallic2 ("Metallic2", Range(0, 1)) = 0
		[HideInInspector] [Gamma] _Metallic3 ("Metallic3", Range(0, 1)) = 0
		[HideInInspector] [Gamma] _Metallic1 ("Metallic1", Range(0, 1)) = 0
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[Space(20)] [Header(General Properties)] [KeywordEnum( Specular_Metallic, Anisotropic_Gloss, Retroreflective )] S ("Specular mode", Float) = 0
		g_flFresnelFalloff ("Fresnel Falloff Scalar", Range(0, 10)) = 1
		g_flFresnelExponent ("Fresnel Exponent", Range(0.5, 10)) = 5
		[Space(5)] [Toggle( _BRDFMAP )] EnableBRDFMAP ("Enable BRDF remap", Float) = 0
		[NoScaleOffset] g_tBRDFMap ("BRDF LUT", 2D) = "grey" {}
		[Space(10)] [Header(Override Properties)] g_flCubeMapScalar ("Cube Map Scalar", Range(0, 2)) = 1
		[Toggle( S_RECEIVE_SHADOWS )] ReceiveShadows ("Receive Shadows", Float) = 1
		[Toggle( _FLUORESCENCEMAP )] Fluorescence ("Enable Fluorescence", Float) = 0
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