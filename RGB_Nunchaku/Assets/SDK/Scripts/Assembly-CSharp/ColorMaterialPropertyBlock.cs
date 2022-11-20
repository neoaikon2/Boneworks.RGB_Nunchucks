using UnityEngine;

public class ColorMaterialPropertyBlock : MonoBehaviour
{
	[SerializeField]
	private Renderer[] Renderers;
	[SerializeField]
	private string[] PropertyNames;
	[SerializeField]
	private bool ColorOnAwake;
	[SerializeField]
	private Color DefaultColor;
}
