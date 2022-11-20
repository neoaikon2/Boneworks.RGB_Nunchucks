using UnityEngine;

public class RFX4_ParticleTrail : MonoBehaviour
{
	public GameObject Target;
	public Vector2 DefaultSizeMultiplayer;
	public float VertexLifeTime;
	public float TrailLifeTime;
	public bool UseShaderMaterial;
	public Material TrailMaterial;
	public bool UseColorOverLifeTime;
	public Gradient ColorOverLifeTime;
	public float ColorLifeTime;
	public bool UseUvAnimation;
	public int TilesX;
	public int TilesY;
	public int FPS;
	public bool IsLoop;
	public float MinVertexDistance;
	public bool GetVelocityFromParticleSystem;
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
}
