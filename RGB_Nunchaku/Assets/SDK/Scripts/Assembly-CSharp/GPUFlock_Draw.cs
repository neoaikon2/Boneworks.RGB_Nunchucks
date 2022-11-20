using UnityEngine;

public class GPUFlock_Draw : MonoBehaviour
{
	public ComputeShader _ComputeFlock;
	public int BoidsCount;
	public float SpawnRadius;
	public Transform Target;
	public Mesh BoidMesh;
	public Material BoidMaterial;
	public float RotationSpeed;
	public float BoidSpeed;
	public float NeighbourDistance;
	public float BoidSpeedVariation;
}
