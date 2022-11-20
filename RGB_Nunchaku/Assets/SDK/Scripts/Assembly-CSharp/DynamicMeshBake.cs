using UnityEngine;
using System;
using StressLevelZero.Data;

public class DynamicMeshBake : MonoBehaviour
{
	[Serializable]
	public struct SkinMeshToRender
	{
		public SkinnedMeshRenderer skinnedMesh;
		public int[] subMeshesIndicies;
	}

	[Serializable]
	public struct MeshToRender
	{
		public Mesh mesh;
		public int[] subMeshesIndicies;
	}

	public SpawnableObject meshSpawnObject;
	public SkinMeshToRender[] skinMeshesToRender;
	public MeshToRender[] meshesToRender;
	public MeshFilter targetFilter;
	public Mesh targetMesh;
}
