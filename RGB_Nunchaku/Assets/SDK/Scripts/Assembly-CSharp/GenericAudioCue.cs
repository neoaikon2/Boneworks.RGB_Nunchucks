using UnityEngine;

public class GenericAudioCue : MonoBehaviour
{
	public AudioClip[] clip_lightImpact;
	public AudioClip[] clip_heavyImpact;
	public AudioClip[] clip_destroyImpact;
	public AudioClip[] clip_success;
	public AudioClip[] clip_fail;
	[SerializeField]
	private float m_lightKnockThresh;
	[SerializeField]
	private float m_hardKnockThresh;
	[SerializeField]
	private float m_brokeKnockThresh;
	[SerializeField]
	private bool m_canBreak;
}
