using UnityEngine;

public class SlideObjectControl : MonoBehaviour
{
	public float parentScale;
	public bool FreeDrawer;
	public float springPower;
	public float damperPower;
	public float targetPosition_closed;
	public float targetPosition_open;
	public bool Locked;
	public AudioClip[] clip_Locked;
	public AudioClip[] clip_Lock;
	public AudioClip[] clip_Unlock;
	public AudioClip clip_Slam;
}
