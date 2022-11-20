using UnityEngine;

public class AudioSync : StateMachineBehaviour
{
	public enum SubtitlePlacement
	{
		Middle = 0,
		Top = 1,
		Bottom = 2,
	}

	public AudioClip audioClip;
	public bool randomOffset;
	public bool looping;
	public string key;
	public float SubtitleBufferTime;
	public SubtitlePlacement SubPlacement;
}
