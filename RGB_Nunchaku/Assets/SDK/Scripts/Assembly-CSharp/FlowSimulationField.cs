using UnityEngine;

public class FlowSimulationField : MonoBehaviour
{
	public float strength;
	public Texture2D falloffTexture;
	[SerializeField]
	protected GpuRenderPlane renderPlane;
}
