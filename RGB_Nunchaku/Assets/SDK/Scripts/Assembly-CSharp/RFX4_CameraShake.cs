using UnityEngine;

public class RFX4_CameraShake : MonoBehaviour
{
	public AnimationCurve ShakeCurve;
	public float Duration;
	public float Speed;
	public float Magnitude;
	public float DistanceForce;
	public float RotationDamper;
	public bool IsEnabled;
	public bool canUpdate;
}
