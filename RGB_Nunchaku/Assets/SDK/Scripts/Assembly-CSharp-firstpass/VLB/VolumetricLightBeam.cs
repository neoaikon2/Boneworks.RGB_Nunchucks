using UnityEngine;

namespace VLB
{
	public class VolumetricLightBeam : MonoBehaviour
	{
		public enum AttenuationEquation
		{
			Linear = 0,
			Quadratic = 1,
			Blend = 2,
		}

		public bool colorFromLight;
		public Color color;
		public float alphaInside;
		public float alphaOutside;
		public bool spotAngleFromLight;
		public float spotAngle;
		public float coneRadiusStart;
		public int geomSides;
		public bool geomCap;
		public bool fadeEndFromLight;
		public AttenuationEquation attenuationEquation;
		public float attenuationCustomBlending;
		public float fadeStart;
		public float fadeEnd;
		public float depthBlendDistance;
		public float DepthBlendStart;
		public float cameraClippingDistance;
		public float glareFrontal;
		public float glareBehind;
		public float boostDistanceInside;
		public float fresnelPowInside;
		public float fresnelPow;
		public bool noiseEnabled;
		public float noiseIntensity;
		public bool noiseScaleUseGlobal;
		public float noiseScaleLocal;
		public bool noiseVelocityUseGlobal;
		public Vector3 noiseVelocityLocal;
		public bool trackChangesDuringPlaytime;
		[SerializeField]
		private int pluginVersion;
	}
}
