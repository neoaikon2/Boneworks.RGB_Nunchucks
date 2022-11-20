using UnityEngine;

public class GizmoSpline : MonoBehaviour
{
	[SerializeField]
	private Transform[] controlPoints;
	[SerializeField]
	private bool isReady;
	[SerializeField]
	private float segmentDiv;
}
