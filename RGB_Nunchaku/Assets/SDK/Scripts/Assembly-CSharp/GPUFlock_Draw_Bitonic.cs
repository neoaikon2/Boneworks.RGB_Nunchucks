using UnityEngine;
using System.Collections.Generic;

public class GPUFlock_Draw_Bitonic : MonoBehaviour
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
	public float Test;
	public List<Vector4> ListOfDistances;
	public List<Vector3> ListOfPositions;
	public List<uint> ListOfKeys;
	public List<float> ListOfValues;
	public List<uint> ListOfValueIdxToKeyIdx;
	public List<float> ListOfTests;
	public List<Vector3> ListOfPositionsRanked;
	public float AvgOfTests;
	public int NbErrored;
	public int NotSorted;
}
