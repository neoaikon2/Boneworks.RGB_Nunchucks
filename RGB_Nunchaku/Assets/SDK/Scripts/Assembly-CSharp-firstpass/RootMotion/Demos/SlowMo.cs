using UnityEngine;

namespace RootMotion.Demos
{
	public class SlowMo : MonoBehaviour
	{
		[SerializeField]
		private KeyCode[] keyCodes;
		[SerializeField]
		private bool mouse0;
		[SerializeField]
		private bool mouse1;
		[SerializeField]
		private float slowMoTimeScale;
	}
}
