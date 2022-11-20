using UnityEngine;
using System;
using System.Collections.Generic;

public class CombinedMesh : MonoBehaviour
{
	[Serializable]
	public class ObjectInfo
	{
		public Material[] aMaterials;
		public Mesh mesh;
		public Vector3 v3LocalPosition;
		public Quaternion qLocalRotation;
		public Vector3 v3LocalScale;
		public Matrix4x4 mtxLocal;
		public Matrix4x4 mtxWorld;
		public Vector3[] av3NormalsWorld;
		public Vector4[] av4TangentsWorld;
	}

	public enum EPivotMode
	{
		Keep = 0,
		Center = 1,
		BottomCenter = 2,
		TopCenter = 3,
		Min = 4,
		Max = 5,
	}

	public bool SaveMeshAsset;
	public bool KeepPosition;
	public EPivotMode PivotMode;
	public MeshFilter[] MeshObjects;
	public GameObject RootNode;
	[SerializeField]
	private List<CombinedMesh.ObjectInfo> m_listObjectInfo;
}
