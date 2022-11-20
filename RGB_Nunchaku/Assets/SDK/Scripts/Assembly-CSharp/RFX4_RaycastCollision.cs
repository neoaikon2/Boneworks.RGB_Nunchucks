using UnityEngine;
using System.Collections.Generic;

public class RFX4_RaycastCollision : MonoBehaviour
{
	public float RaycastDistance;
	public GameObject[] Effects;
	public float Offset;
	public float TimeDelay;
	public float DestroyTime;
	public bool UsePivotPosition;
	public bool UseNormalRotation;
	public bool IsWorldSpace;
	public bool RealTimeUpdateRaycast;
	public bool DestroyAfterDisabling;
	public float HUE;
	public List<GameObject> CollidedInstances;
}
