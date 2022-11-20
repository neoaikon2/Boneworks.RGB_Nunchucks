using UnityEngine;

namespace VLB
{
	public class Config : ScriptableObject
	{
		public int geometryLayerID;
		public Shader beamShader;
		public float globalNoiseScale;
		public Vector3 globalNoiseVelocity;
		public TextAsset noise3DData;
		public int noise3DSize;
		public ParticleSystem dustParticlesPrefab;
	}
}
