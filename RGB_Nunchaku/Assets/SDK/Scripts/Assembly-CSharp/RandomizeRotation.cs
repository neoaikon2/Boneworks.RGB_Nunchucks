using UnityEngine;

public class RandomizeRotation : MonoBehaviour
{
	private enum Direction
	{
		Up = 0,
		Forward = 1,
		Right = 2,
	}

	[SerializeField]
	private bool RotateOnEnable;
	[SerializeField]
	private float Rotation;
	[SerializeField]
	private Direction direction;
}
