using System;
using UnityEngine;
using UnityEngine.Audio;

namespace PuppetMasta
{
	[Serializable]
	public class SubBehaviourFaceanim : SubBehaviourBase
	{
		[Serializable]
		public class FaceEvent
		{
			public enum TriggerIndex
			{
				Greeting = 0,
				UnAgro = 1,
				PainSmall = 2,
				PainBig = 3,
				Death = 4,
				EventLine = 5,
			}

			public AudioClip clip;
			public TriggerIndex triggerIndex;
			public int animIndex;
		}

		public bool faceAnimEnabled;
		public AudioMixerGroup mixerGroup;
		public Transform mouthTran;
		[SerializeField]
		private FaceEvent[] greetings;
		[SerializeField]
		private FaceEvent[] agros;
		[SerializeField]
		private FaceEvent[] unAgros;
		[SerializeField]
		private FaceEvent[] deaths;
		[SerializeField]
		private FaceEvent[] painSmalls;
		[SerializeField]
		private FaceEvent[] painBigs;
		[SerializeField]
		private FaceEvent[] attack1s;
		[SerializeField]
		private FaceEvent[] efforts;
		[SerializeField]
		private FaceEvent[] eventLines;
	}
}
