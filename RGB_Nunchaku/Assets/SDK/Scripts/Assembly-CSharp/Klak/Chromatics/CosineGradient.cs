using UnityEngine;

namespace Klak.Chromatics
{
	public class CosineGradient : ScriptableObject
	{
		[SerializeField]
		private Vector4 _redCoeffs;
		[SerializeField]
		private Vector4 _greenCoeffs;
		[SerializeField]
		private Vector4 _blueCoeffs;
	}
}
