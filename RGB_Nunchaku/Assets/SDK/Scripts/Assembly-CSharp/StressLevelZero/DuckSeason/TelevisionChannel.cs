using UnityEngine;

namespace StressLevelZero.DuckSeason
{
	public class TelevisionChannel : MonoBehaviour
	{
		public AudioSource _tvAudioSource;
		public RectTransform _myRectTransform;
		public TelevisionChannelManager manager;
		public bool isTurnedOn;
		public bool isPlaying;
		public bool isMuted;
	}
}
