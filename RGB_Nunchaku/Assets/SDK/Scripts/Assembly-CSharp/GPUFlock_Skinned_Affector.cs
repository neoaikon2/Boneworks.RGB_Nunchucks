using UnityEngine;

public class GPUFlock_Skinned_Affector : MonoBehaviour
{
	public ComputeShader _ComputeFlock;
	public GameObject TargetBoidToGPUSkin;
	public AnimationClip _AnimationClip;
	public int BoidsCount;
	public float SpawnRadius;
	public Transform Target;
	public Mesh BoidMesh;
	public Material BoidMaterial;
	public TextAsset DrawingAffectors;
	public float ScaleDrawingAffectors;
	public bool ReverseYAxisDrawingAffectors;
	public Vector3 DrawingAffectorsOffset;
	public bool DrawDrawingAffectors;
	public float RayAffectorDistance;
	public int NbAffectorsPerRay;
	public float RotationSpeed;
	public float BoidSpeed;
	public float NeighbourDistance;
	public float BoidSpeedVariation;
	public float BoidFrameSpeed;
	public bool FrameInterpolation;
	public float AffectorForce;
	public float AffectorDistance;
}
