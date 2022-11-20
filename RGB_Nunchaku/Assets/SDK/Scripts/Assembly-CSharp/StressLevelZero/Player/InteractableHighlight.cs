using UnityEngine;

namespace StressLevelZero.Player
{
	public class InteractableHighlight : MonoBehaviour
	{
		[SerializeField]
		public bool CloneSettings;
		[SerializeField]
		private NearEvents nearEvents;
		[SerializeField]
		private FarEvents farEvents;
	}
}
