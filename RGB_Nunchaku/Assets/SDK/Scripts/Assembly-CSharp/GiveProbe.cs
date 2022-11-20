using UnityEngine;
using System.Collections.Generic;

public class GiveProbe : MonoBehaviour
{
	[SerializeField]
	private Vector3 size;
	[SerializeField]
	private bool useTransform;
	[SerializeField]
	private Collider collider;
	[SerializeField]
	private List<MeshRenderer> meshes;
}
