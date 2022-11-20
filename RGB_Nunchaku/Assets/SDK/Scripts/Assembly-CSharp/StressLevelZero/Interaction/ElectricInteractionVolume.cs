using UnityEngine;
using UnityEngine.Audio;
using System.Collections.Generic;
using StressLevelZero;

namespace StressLevelZero.Interaction
{
	public class ElectricInteractionVolume : InteractionVolume
	{
		public Transform targetPos;
		public Collider[] recieverColliders;
		public AudioClip[] insertClips;
		public AudioClip[] removeClips;
		public AudioMixerGroup mixerGroup;
		public float volume;
		[SerializeField]
		private List<PowerSourceType> m_acceptedTypes;
		public SaveItem saveItem;
	}
}
