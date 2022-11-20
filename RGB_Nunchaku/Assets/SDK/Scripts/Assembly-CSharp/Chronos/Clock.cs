using UnityEngine;

namespace Chronos
{
	public class Clock : MonoBehaviour
	{
		[SerializeField]
		private float _localTimeScale;
		[SerializeField]
		private bool _paused;
		[SerializeField]
		private string _parentKey;
		[SerializeField]
		private ClockBlend _parentBlend;
	}
}
