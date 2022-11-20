using UnityEngine;
using Klak.Chromatics;

namespace Swarm
{
	public class FloatingSwarm : MonoBehaviour
	{
		[SerializeField]
		private int _instanceCount;
		[SerializeField]
		private TubeTemplate _template;
		[SerializeField]
		private float _radius;
		[SerializeField]
		private float _trim;
		[SerializeField]
		private Transform _attractor;
		[SerializeField]
		private Vector3 _attractorPosition;
		[SerializeField]
		private float _attractorSpread;
		[SerializeField]
		private float _attractorForce;
		[SerializeField]
		private float _forceRandomness;
		[SerializeField]
		private float _drag;
		[SerializeField]
		private float _headNoiseForce;
		[SerializeField]
		private float _headNoiseFrequency;
		[SerializeField]
		private float _trailNoiseVelocity;
		[SerializeField]
		private float _trailNoiseFrequency;
		[SerializeField]
		private float _noiseSpread;
		[SerializeField]
		private float _noiseMotion;
		[SerializeField]
		private Material _material;
		[SerializeField]
		private CosineGradient _gradient;
		[SerializeField]
		private int _randomSeed;
		[SerializeField]
		private ComputeShader _compute;
	}
}
