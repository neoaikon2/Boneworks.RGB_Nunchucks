using UnityEngine;

public class Gizmo : MonoBehaviour
{
	public enum GizmoFeatures
	{
		Box = 1,
		Sphere = 2,
		Cross = 4,
		Mesh = 8,
	}

	[SerializeField]
	private Color GizmoColor;
	[SerializeField]
	private Mesh GizmoMesh;
	[SerializeField]
	public GizmoFeatures gizmoFeatures;
}
