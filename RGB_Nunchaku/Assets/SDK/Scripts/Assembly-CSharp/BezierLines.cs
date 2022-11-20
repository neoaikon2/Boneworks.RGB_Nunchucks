using UnityEngine;

public class BezierLines : MonoBehaviour
{
	[SerializeField]
	private int segmentsCount;
	public Transform[] transPoints;
	public Vector3[] tempPoints;
	public Material lineMat;
}
