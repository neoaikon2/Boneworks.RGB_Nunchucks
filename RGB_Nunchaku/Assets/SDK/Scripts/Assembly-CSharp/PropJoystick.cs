using StressLevelZero.Interaction;
using UnityEngine;

public class PropJoystick : SphereGrip
{
	public Transform locator;
	public Rigidbody rb_Joystick;
	public Vector2 rot_xy;
	public Transform rotBall;
	public float maxDegrees;
	public float deadzoneDegrees;
	public GameObject[] msg_Objects;
}
