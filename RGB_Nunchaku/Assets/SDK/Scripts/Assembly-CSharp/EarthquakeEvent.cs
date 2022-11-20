using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.Audio;

public class EarthquakeEvent : MonoBehaviour
{
	[Serializable]
	public class Events
	{
		public float time;
		public Rigidbody rb;
		public Transform atPosition;
		public float magnitude;
		public ConfigurableJoint joint;
	}

	public List<EarthquakeEvent.Events> events;
	public AudioClip earthquakeStart;
	public AudioMixerGroup mixerGroup;
}
