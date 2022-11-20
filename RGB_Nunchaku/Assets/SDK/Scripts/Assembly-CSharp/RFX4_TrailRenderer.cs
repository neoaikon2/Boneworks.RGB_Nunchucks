using UnityEngine;

public class RFX4_TrailRenderer : MonoBehaviour
{
	public float VertexLifeTime;
	public float TrailLifeTime;
	public float MinVertexDistance;
	public float Gravity;
	public Vector3 Force;
	public float InheritVelocity;
	public float Drag;
	public float Frequency;
	public float OffsetSpeed;
	public bool RandomTurbulenceOffset;
	public float Amplitude;
	public float TurbulenceStrength;
	public AnimationCurve VelocityByDistance;
	public float AproximatedFlyDistance;
	public bool SmoothCurves;
	public float currentLifeTime;
}
