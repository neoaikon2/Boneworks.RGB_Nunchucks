using UnityEngine;

namespace StressLevelZero.DuckSeason
{
	public class VHSPlayer : MonoBehaviour
	{
		public enum VHSState
		{
			EMPTY = 0,
			LOADING = 1,
			EJECTING = 2,
		}

		public TelevisionBase television;
		public VHSTape defaultVHSTape;
		public Transform tapeCarryTransform;
		public float ejectForceMuiltiplier;
		public AudioClip InsertSound;
		public AudioClip EjectSound;
		public VHSReciever reciever;
		public VHSState curState;
	}
}
