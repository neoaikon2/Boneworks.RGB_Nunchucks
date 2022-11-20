using UnityEngine;

public class RFX4_Turbulence : MonoBehaviour
{
	public enum MoveMethodEnum
	{
		Position = 0,
		Velocity = 1,
		RelativePosition = 2,
	}

	public enum PerfomanceEnum
	{
		High = 0,
		Low = 1,
	}

	public float TurbulenceStrenght;
	public bool TurbulenceByTime;
	public float TimeDelay;
	public AnimationCurve TurbulenceStrengthByTime;
	public Vector3 Frequency;
	public Vector3 OffsetSpeed;
	public Vector3 Amplitude;
	public Vector3 GlobalForce;
	public bool UseGlobalOffset;
	public MoveMethodEnum MoveMethod;
	public PerfomanceEnum Perfomance;
	public float ThreshholdSpeed;
	public AnimationCurve VelocityByDistance;
	public float AproximatedFlyDistance;
}
