using UnityEngine;
using StressLevelZero.Data;

namespace StressLevelZero.VFX
{
	public class DespawnMeshVFX : MonoBehaviour
	{
		public SpawnableObject meshSpawnObject;
		public SkinnedMeshRenderer[] _skinMeshRenderers;
		public MeshRenderer[] _meshRenderers;
		public MeshFilter[] _meshFilters;
		public AudioClip despawnAudioClip;
	}
}
