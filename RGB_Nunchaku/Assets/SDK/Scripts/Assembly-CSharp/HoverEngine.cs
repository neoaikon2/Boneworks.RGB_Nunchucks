using UnityEngine;

public class HoverEngine : MonoBehaviour
{
	public LayerMask RaycastMask;
	public float MaxHeight;
	public float GroundForce;
	public float Damping;
	public float Exponent;
	public float MaxAngleDrift;
	public Rigidbody Rigidbody;
}
