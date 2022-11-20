using UnityEngine;
using System;

public class DoorScript : MonoBehaviour
{
	[Serializable]
	public class DoorControls
	{
		public float openingSpeed;
		public float closingSpeed;
		public float closeStartFrom;
		public DoorScript.OpenStyle openMethod;
		public KeyCode openButton;
		public bool autoClose;
	}

	[Serializable]
	public class AnimNames
	{
		public string OpeningAnim;
		public string LockedAnim;
	}

	[Serializable]
	public class DoorSounds
	{
		public bool enabled;
		public AudioClip open;
		public AudioClip close;
		public AudioClip closed;
		public float volume;
		public float pitchRandom;
	}

	[Serializable]
	public class DoorTexts
	{
		public bool enabled;
		public string openingText;
		public string closingText;
		public string lockText;
		public GameObject TextPrefab;
	}

	[Serializable]
	public class KeySystem
	{
		public bool enabled;
		public bool isUnlock;
		public GameObject LockPrefab;
	}

	public enum OpenStyle
	{
		BUTTON = 0,
		AUTOMATIC = 1,
	}

	public string PlayerHeadTag;
	public Transform knob;
	public DoorControls controls;
	public AnimNames AnimationNames;
	public DoorSounds doorSounds;
	public DoorTexts doorTexts;
	public KeySystem keySystem;
}
