using UnityEngine;

public class GPUFlockCompute : MonoBehaviour
{
	public ComputeShader cshader;
	public GameObject boidPrefab;
	public int BoidsCount;
	public float SpawnRadius;
	public GameObject[] boidsGo;
	public Transform Target;
	public float RotationSpeed;
	public float BoidSpeed;
	public float NeighbourDistance;
	public float BoidSpeedVariation;
}
