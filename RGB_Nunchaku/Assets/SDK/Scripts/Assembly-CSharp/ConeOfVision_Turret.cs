using UnityEngine;
using VLB;

public class ConeOfVision_Turret : MonoBehaviour
{
	public float visionRadius;
	public float visionAngle;
	public Enemy_Turret turret;
	public LayerMask mask;
	public Color idleColor;
	public Color aggroColor;
	public VolumetricLightBeam beam;
	public Transform acquiredTarget;
}
