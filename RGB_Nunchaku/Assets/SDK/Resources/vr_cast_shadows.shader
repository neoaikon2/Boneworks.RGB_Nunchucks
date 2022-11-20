Shader "Valve/Internal/vr_cast_shadows" {
	Properties {
	}
	SubShader {
		LOD 300
		Tags { "PerformanceChecks" = "False" "RenderType" = "Opaque" }
		Pass {
			Name "ValveShadowCaster"
			LOD 300
			Tags { "PerformanceChecks" = "False" "RenderType" = "Opaque" "SHADOWSUPPORT" = "true" }
			ColorMask 0 -1
			Offset 2.5, 1
			GpuProgramID 21588
			Program "vp" {
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_DEPTH" }
					"!!vs_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_DEPTH" "STEREO_CUBEMAP_RENDER_ON" }
					"!!vs_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_DEPTH" "STEREO_INSTANCING_ON" }
					"!!vs_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_DEPTH" "STEREO_INSTANCING_ON" "STEREO_CUBEMAP_RENDER_ON" }
					"!!vs_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_CUBE" }
					"!!vs_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_CUBE" "STEREO_CUBEMAP_RENDER_ON" }
					"!!vs_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_CUBE" "STEREO_INSTANCING_ON" }
					"!!vs_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_CUBE" "STEREO_INSTANCING_ON" "STEREO_CUBEMAP_RENDER_ON" }
					"!!vs_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_DEPTH" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!vs_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_DEPTH" "STEREO_CUBEMAP_RENDER_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!vs_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_DEPTH" "STEREO_INSTANCING_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!vs_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_DEPTH" "STEREO_INSTANCING_ON" "STEREO_CUBEMAP_RENDER_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!vs_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_CUBE" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!vs_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_CUBE" "STEREO_CUBEMAP_RENDER_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!vs_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_CUBE" "STEREO_INSTANCING_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!vs_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_CUBE" "STEREO_INSTANCING_ON" "STEREO_CUBEMAP_RENDER_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!vs_4_0
					/*Can't export program data d3d11 as a text*/"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_DEPTH" }
					"!!ps_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_DEPTH" "STEREO_CUBEMAP_RENDER_ON" }
					"!!ps_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_DEPTH" "STEREO_INSTANCING_ON" }
					"!!ps_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_DEPTH" "STEREO_INSTANCING_ON" "STEREO_CUBEMAP_RENDER_ON" }
					"!!ps_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_CUBE" }
					"!!ps_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_CUBE" "STEREO_CUBEMAP_RENDER_ON" }
					"!!ps_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_CUBE" "STEREO_INSTANCING_ON" }
					"!!ps_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_CUBE" "STEREO_INSTANCING_ON" "STEREO_CUBEMAP_RENDER_ON" }
					"!!ps_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_DEPTH" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!ps_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_DEPTH" "STEREO_CUBEMAP_RENDER_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!ps_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_DEPTH" "STEREO_INSTANCING_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!ps_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_DEPTH" "STEREO_INSTANCING_ON" "STEREO_CUBEMAP_RENDER_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!ps_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_CUBE" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!ps_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_CUBE" "STEREO_CUBEMAP_RENDER_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!ps_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_CUBE" "STEREO_INSTANCING_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!ps_4_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "SHADOWS_CUBE" "STEREO_INSTANCING_ON" "STEREO_CUBEMAP_RENDER_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!ps_4_0
					/*Can't export program data d3d11 as a text*/"
				}
			}
		}
	}
	SubShader {
		LOD 300
		Tags { "PerformanceChecks" = "False" "RenderType" = "TransparentCutout" }
		Pass {
			Name "ValveShadowCaster"
			LOD 300
			Tags { "LIGHTMODE" = "FORWARDBASE" "PerformanceChecks" = "False" "RenderType" = "TransparentCutout" }
			ColorMask 0 -1
			Offset 2.5, 1
			GpuProgramID 79512
			Program "vp" {
				SubProgram "d3d11 " {
					"!!vs_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_CUBEMAP_RENDER_ON" }
					"!!vs_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_INSTANCING_ON" }
					"!!vs_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_INSTANCING_ON" "STEREO_CUBEMAP_RENDER_ON" }
					"!!vs_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!vs_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_CUBEMAP_RENDER_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!vs_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_INSTANCING_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!vs_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_INSTANCING_ON" "STEREO_CUBEMAP_RENDER_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!vs_5_0
					/*Can't export program data d3d11 as a text*/"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"!!ps_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_CUBEMAP_RENDER_ON" }
					"!!ps_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_INSTANCING_ON" }
					"!!ps_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_INSTANCING_ON" "STEREO_CUBEMAP_RENDER_ON" }
					"!!ps_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!ps_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_CUBEMAP_RENDER_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!ps_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_INSTANCING_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!ps_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_INSTANCING_ON" "STEREO_CUBEMAP_RENDER_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!ps_5_0
					/*Can't export program data d3d11 as a text*/"
				}
			}
		}
	}
	SubShader {
		LOD 300
		Tags { "PerformanceChecks" = "False" "RenderType" = "ValveTransparent" }
		Pass {
			Name "ValveShadowCaster"
			LOD 300
			Tags { "LIGHTMODE" = "FORWARDBASE" "PerformanceChecks" = "False" "RenderType" = "ValveTransparent" }
			ColorMask 0 -1
			Offset 2.5, 1
			GpuProgramID 194087
			Program "vp" {
				SubProgram "d3d11 " {
					"!!vs_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_CUBEMAP_RENDER_ON" }
					"!!vs_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_INSTANCING_ON" }
					"!!vs_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_INSTANCING_ON" "STEREO_CUBEMAP_RENDER_ON" }
					"!!vs_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!vs_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_CUBEMAP_RENDER_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!vs_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_INSTANCING_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!vs_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_INSTANCING_ON" "STEREO_CUBEMAP_RENDER_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!vs_5_0
					/*Can't export program data d3d11 as a text*/"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"!!ps_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_CUBEMAP_RENDER_ON" }
					"!!ps_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_INSTANCING_ON" }
					"!!ps_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_INSTANCING_ON" "STEREO_CUBEMAP_RENDER_ON" }
					"!!ps_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!ps_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_CUBEMAP_RENDER_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!ps_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_INSTANCING_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!ps_5_0
					/*Can't export program data d3d11 as a text*/"
				}
				SubProgram "d3d11 " {
					Keywords { "STEREO_INSTANCING_ON" "STEREO_CUBEMAP_RENDER_ON" "MATRIX_PALETTE_SKINNING_1BONE" }
					"!!ps_5_0
					/*Can't export program data d3d11 as a text*/"
				}
			}
		}
	}
}