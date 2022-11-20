using UnityEngine;

public class AssignGeneratorUV : MonoBehaviour
{
	[SerializeField]
	private FlowmapGenerator generator;
	[SerializeField]
	private Vector3 position;
	[SerializeField]
	private Vector2 dimensions;
	[SerializeField]
	private Renderer[] renderers;
	[SerializeField]
	private bool assignToSharedMaterial;
	[SerializeField]
	private string uvVectorName;
}
