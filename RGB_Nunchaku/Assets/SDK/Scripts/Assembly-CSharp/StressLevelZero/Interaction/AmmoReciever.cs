using UnityEngine;

namespace StressLevelZero.Interaction
{
	public class AmmoReciever : InteractionReciever
	{
		public Transform startInsertTarget;
		public Transform endInsertTarget;
		public AudioClip[] insertClips;
		public AudioClip[] ejectClips;
	}
}
