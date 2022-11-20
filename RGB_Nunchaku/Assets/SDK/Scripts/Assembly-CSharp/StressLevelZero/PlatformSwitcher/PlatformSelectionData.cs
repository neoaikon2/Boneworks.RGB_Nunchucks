using UnityEngine;

namespace StressLevelZero.PlatformSwitcher
{
	public class PlatformSelectionData : ScriptableObject
	{
		[SerializeField]
		public PLATFORM platform;
		[SerializeField]
		public string appId;
	}
}
