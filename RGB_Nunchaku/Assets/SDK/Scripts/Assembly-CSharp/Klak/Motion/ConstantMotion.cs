using UnityEngine;

namespace Klak.Motion
{
	public class ConstantMotion : MonoBehaviour
	{
		public enum TranslationMode
		{
			Off = 0,
			XAxis = 1,
			YAxis = 2,
			ZAxis = 3,
			Vector = 4,
			Random = 5,
		}

		public enum RotationMode
		{
			Off = 0,
			XAxis = 1,
			YAxis = 2,
			ZAxis = 3,
			Vector = 4,
			Random = 5,
		}

		[SerializeField]
		private TranslationMode _translationMode;
		[SerializeField]
		private Vector3 _translationVector;
		[SerializeField]
		private float _translationSpeed;
		[SerializeField]
		private RotationMode _rotationMode;
		[SerializeField]
		private Vector3 _rotationAxis;
		[SerializeField]
		private float _rotationSpeed;
		[SerializeField]
		private bool _useLocalCoordinate;
	}
}
