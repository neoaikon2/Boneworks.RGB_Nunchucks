using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class FinalFiestaControl : TelevisionChannel
	{
		public RectTransform poncho;
		public RectTransform sombraro;
		public RectTransform juan;
		public GameObject titlePanel;
		public GameObject introPanel;
		public GameObject walkPanel;
		public Animator introAnimator;
		public AudioClip ffMusicAudioClip;
		public AudioClip WindSound;
		public GameObject PartyStuff;
		public GameObject PartyLight;
		public float fadetime;
		public Text dialogueText;
		public float letterPause;
		public string message_A;
		public string message_B;
		public string message_C;
		public string message_D;
		public string message_E;
		public string message_F;
		public string message_G;
		public int messageInt;
		public string currentMessage;
		public Text jobTitleText;
		public Text jobNameText;
	}
}
