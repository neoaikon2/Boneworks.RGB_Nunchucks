using UnityEngine;
using System;

public class SimplifyMeshPreview : MonoBehaviour
{
	[Serializable]
	public class ShowcaseObject
	{
		public MeshSimplify m_meshSimplify;
		public Vector3 m_position;
		public Vector3 m_angles;
		public Vector3 m_rotationAxis;
		public string m_description;
	}

	public ShowcaseObject[] ShowcaseObjects;
	public Material WireframeMaterial;
	public float MouseSensitvity;
	public float MouseReleaseSpeed;
}
