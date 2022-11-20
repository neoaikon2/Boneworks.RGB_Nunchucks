using UnityEngine;
using System;

public class LODPreview : MonoBehaviour
{
	[Serializable]
	public class ShowcaseObject
	{
		public AutomaticLOD m_automaticLOD;
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
