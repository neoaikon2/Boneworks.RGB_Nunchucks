using UnityEngine;

public class GarageDoorControl : MonoBehaviour
{
	public bool Powered;
	public float DoorDuration;
	public Transform SlatParent;
	public Transform[] SlatArr;
	public Transform ColliderTrans;
	public float m_upPerc;
	public float m_downPerc;
	public Vector3 currPos;
	public Vector3 startPos;
	public float currDistTraveled;
	public float startTime;
	public float debug_upTimeEnd;
	public float timeTraveled;
	public float currSpeed;
	public float UpTime;
	public float DownTime;
}
