using UnityEngine;
using DFVolume;
using Klak.Chromatics;

namespace Swarm
{
	public class CrawlingSwarm : MonoBehaviour
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
		private float _speed;
		[SerializeField]
		private VolumeData _volume;
		[SerializeField]
		private float _initialSpread;
		[SerializeField]
		private float _noiseFrequency;
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
