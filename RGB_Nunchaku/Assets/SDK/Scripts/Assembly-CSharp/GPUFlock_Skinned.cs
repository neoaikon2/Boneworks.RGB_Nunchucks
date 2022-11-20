using UnityEngine;

public class GPUFlock_Skinned : MonoBehaviour
{
	public ComputeShader _ComputeFlock;
	public GameObject TargetBoidToGPUSkin;
	public AnimationClip _AnimationClip;
	public int BoidsCount;
	public float SpawnRadius;
	public Transform Target;
	public Mesh BoidMesh;
	public Material BoidMaterial;
	public float RotationSpeed;
	public float BoidSpeed;
	public float NeighbourDistance;
	public float BoidSpeedVariation;
	public float BoidFrameSpeed;
	public bool FrameInterpolation;
}
