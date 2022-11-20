using UnityEngine;
using System.Collections.Generic;
using StressLevelZero.AI;
using UnityEngine.Audio;

namespace StressLevelZero.Arena
{
	public class Arena_DoorController : MonoBehaviour
	{
		public enum DoorPosition
		{
			NORTH = 0,
			EAST = 1,
			SOUTH = 2,
			WEST = 3,
		}

		public enum DoorState
		{
			OPEN_NORTH = 0,
			CLOSED = 1,
			OPEN_SOUTH = 2,
		}

		public DoorPosition doorPosition;
		public DoorState playerDoorState;
		public List<TriggerRefProxy> enemyTriggerRefList;
		public int currEnemyCount;
		public bool isOpen;
		public Animator myAnimator;
		public AudioMixerGroup audioGroup;
		public AudioClip[] openClips;
		public AudioClip[] closeClips;
		[SerializeField]
		private Arena_DoorOutTrigger doorOutTrigger;
	}
}
