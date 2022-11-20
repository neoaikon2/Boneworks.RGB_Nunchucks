using UnityEngine;
using System;

public class LODSampleLODScene : MonoBehaviour
{
	[Serializable]
	public class SceneCamera
	{
		public Camera m_camera;
		public float m_near;
		public float m_far;
		public Vector3 m_v3InitialCameraPosition;
		public Vector3 m_v3ViewDir;
	}

	public SceneCamera[] SceneCameras;
	public Material WireframeMaterial;
}
