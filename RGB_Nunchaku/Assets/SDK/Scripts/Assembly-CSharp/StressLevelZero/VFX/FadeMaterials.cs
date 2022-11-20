using UnityEngine;

namespace StressLevelZero.VFX
{
	public class FadeMaterials : MonoBehaviour
	{
		[SerializeField]
		private float TimeToFullyFade;
		[SerializeField]
		private string TargetVariable;
		public Renderer[] MaterialsToFade;
	}
}
