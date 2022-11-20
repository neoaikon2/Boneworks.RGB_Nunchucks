using UnityEngine;

public class ZRealtimeAO : MonoBehaviour
{
	public enum AOShape
	{
		Point = 0,
		Sphere = 1,
	}

	public Vector3 SphereScale;
	public AOShape TypeOfShape;
	[SerializeField]
	private bool AccountForScale;
	[SerializeField]
	public float TargetRadius;
}
