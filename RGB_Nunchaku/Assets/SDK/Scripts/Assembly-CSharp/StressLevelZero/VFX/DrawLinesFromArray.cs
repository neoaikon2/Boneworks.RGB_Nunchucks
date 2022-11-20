using UnityEngine;

namespace StressLevelZero.VFX
{
	public class DrawLinesFromArray : MonoBehaviour
	{
		[SerializeField]
		private LineRenderer liner;
		[SerializeField]
		public GameObject[] Points;
	}
}
