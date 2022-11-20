using UnityEngine;
using System.Collections.Generic;

public class GPUFlock_Multilateration : MonoBehaviour
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
	public List<Vector4> ListOfDistances;
	public List<Vector3> ListOfPositions;
}
