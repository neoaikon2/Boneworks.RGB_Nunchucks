using UnityEngine;

public class Billboard : MonoBehaviour
{
	public enum Axis
	{
		up = 0,
		down = 1,
		left = 2,
		right = 3,
		forward = 4,
		back = 5,
	}

	public bool reverseFace;
	public Axis axis;
}
