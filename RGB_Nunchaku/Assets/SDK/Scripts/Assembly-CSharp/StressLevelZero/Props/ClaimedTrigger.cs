using UnityEngine;
using StressLevelZero.Data;
using UnityEngine.Events;

namespace StressLevelZero.Props
{
	public class ClaimedTrigger : MonoBehaviour
	{
		public SpawnableObject claimedSpawnObject;
		public AudioClip[] errorClips;
		public AudioClip[] successClips;
		public UnityEvent onSuccessTrigger;
		public UnityEvent onErrorTrigger;
	}
}
