using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Audio;

public class BellImpactSFX : MonoBehaviour
{
	public UnityEvent onRingBell;
	public AudioClip bellImpactClip;
	public AudioMixerGroup audioGroup;
	public float velocityClipSplit;
}
