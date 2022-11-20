using UnityEngine;

public class DynamicBoneColliderBase : MonoBehaviour
{
	public enum Direction
	{
		X = 0,
		Y = 1,
		Z = 2,
	}

	public enum Bound
	{
		Outside = 0,
		Inside = 1,
	}

	public Direction m_Direction;
	public Vector3 m_Center;
	public Bound m_Bound;
}
