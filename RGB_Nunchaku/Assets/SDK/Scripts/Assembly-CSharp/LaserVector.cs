using UnityEngine;

public class LaserVector : MonoBehaviour
{
	public enum Alignment
	{
		X = 0,
		Y = 1,
		Z = 2,
	}

	public Alignment alignment;
	public Renderer[] renderers;
	public TrailRenderer trail;
}
