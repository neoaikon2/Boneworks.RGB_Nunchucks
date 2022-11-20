using UnityEngine;
using Klak.Chromatics;

namespace Swarm
{
	public class SwirlingSwarm : MonoBehaviour
	{
		[SerializeField]
		private int _instanceCount;
		[SerializeField]
		private TubeTemplate _template;
		[SerializeField]
		private float _radius;
		[SerializeField]
		private float _length;
		[SerializeField]
		private float _spread;
		[SerializeField]
		private float _noiseFrequency;
		[SerializeField]
		private Vector3 _noiseMotion;
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
