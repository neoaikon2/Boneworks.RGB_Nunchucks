using UnityEngine;

public class RFX4_PhysicsForceCurves : MonoBehaviour
{
	public float ForceRadius;
	public float ForceMultiplier;
	public AnimationCurve ForceCurve;
	public ForceMode ForceMode;
	public float GraphTimeMultiplier;
	public float GraphIntensityMultiplier;
	public bool IsLoop;
	public float DestoryDistance;
	public bool UseDistanceScale;
	public AnimationCurve DistanceScaleCurve;
	public bool UseUPVector;
	public AnimationCurve DragCurve;
	public float DragGraphTimeMultiplier;
	public float DragGraphIntensityMultiplier;
	public string AffectedName;
	public float forceAdditionalMultiplier;
}
