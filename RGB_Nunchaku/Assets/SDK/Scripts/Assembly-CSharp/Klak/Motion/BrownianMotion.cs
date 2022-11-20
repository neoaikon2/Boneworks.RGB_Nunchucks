using UnityEngine;

namespace Klak.Motion
{
	public class BrownianMotion : MonoBehaviour
	{
		[SerializeField]
		private bool _enablePositionNoise;
		[SerializeField]
		private bool _enableRotationNoise;
		[SerializeField]
		private float _positionFrequency;
		[SerializeField]
		private float _rotationFrequency;
		[SerializeField]
		private float _positionAmplitude;
		[SerializeField]
		private float _rotationAmplitude;
		[SerializeField]
		private Vector3 _positionScale;
		[SerializeField]
		private Vector3 _rotationScale;
		[SerializeField]
		private int _positionFractalLevel;
		[SerializeField]
		private int _rotationFractalLevel;
	}
}
