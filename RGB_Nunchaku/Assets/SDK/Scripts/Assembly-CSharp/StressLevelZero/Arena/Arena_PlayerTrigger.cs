using UnityEngine;

namespace StressLevelZero.Arena
{
	public class Arena_PlayerTrigger : MonoBehaviour
	{
		public enum TriggerType
		{
			START = 0,
			START_NEXT_ROUND = 1,
			ENTRANCE_DOOR = 2,
			KILL_PLAYER = 3,
			SETUP_NEXT_ROUND = 4,
			PHYS_BUTTON = 5,
			BOX_SPAWN = 6,
			PIT_CHECK = 7,
		}

		public TriggerType triggerType;
		public Collider myCollider;
		public Arena_DoorController doorController;
		public GameControl_Arena storySceneGameControl;
		public Arena_Turret turret;
		public bool isPlayerInBoxSpawn;
		public bool isPlayerInPit;
		[SerializeField]
		private Arena_DoorOutTrigger doorOutTrig;
	}
}
