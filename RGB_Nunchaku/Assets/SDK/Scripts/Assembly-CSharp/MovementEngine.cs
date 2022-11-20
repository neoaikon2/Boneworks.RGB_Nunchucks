using UnityEngine;

public class MovementEngine : MonoBehaviour
{
	public float Thrust;
	public float MaxForwardAcceleration;
	public float MaxReverseAcceleration;
	public float MaxBrakingDeceleration;
	public float AutoBrakingDeceleration;
	public float MaxSpeed;
	public AnimationCurve AccelerationBySpeed;
	public float VerticalReduction;
	public float MaxPitchAngle;
	public Rigidbody Rigidbody;
	public HoverEngine[] HoverEngines;
}
