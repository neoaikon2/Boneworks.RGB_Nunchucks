using UnityEngine;

public class GPUFlock : MonoBehaviour
{
	public ComputeShader _ComputeFlock;
	public GameObject TargetBoidToGPUSkin;
	public Transform Target;
	public Mesh BoidMesh;
	public Material BoidMaterial;
	public AnimationClip _AnimationClip;
	public bool UseAffectors;
	public TextAsset DrawingAffectors;
	public bool UseMeshAffectors;
	public Mesh MeshAffectors;
	public float ScaleDrawingAffectors;
	public bool ReverseYAxisDrawingAffectors;
	public Vector3 DrawingAffectorsOffset;
	public bool DrawDrawingAffectors;
	public int BoidsCount;
	public int StepBoidCheckNeighbours;
	public float SpawnRadius;
	public float RotationSpeed;
	public float BoidSpeed;
	public float NeighbourDistance;
	public float BoidSpeedVariation;
	public float BoidFrameSpeed;
	public bool FrameInterpolation;
	public float AffectorForce;
	public float AffectorDistance;
	public float MaxAffectorFullAxisSize;
	public bool DrawILoveUnity;
	public TextAsset EyeDrawing;
	public TextAsset HeartDrawing;
	public TextAsset UnityDrawing;
}
