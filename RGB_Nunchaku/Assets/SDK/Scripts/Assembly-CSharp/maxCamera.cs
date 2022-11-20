using UnityEngine;

public class maxCamera : MonoBehaviour
{
	public Transform target;
	public Vector3 targetOffset;
	public float distance;
	public float maxDistance;
	public float minDistance;
	public float xSpeed;
	public float ySpeed;
	public int yMinLimit;
	public int yMaxLimit;
	public int zoomRate;
	public float panSpeed;
	public float zoomDampening;
}
