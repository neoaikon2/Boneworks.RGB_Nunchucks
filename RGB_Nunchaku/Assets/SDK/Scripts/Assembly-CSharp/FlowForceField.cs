using Flowmap;
using UnityEngine;

public class FlowForceField : FlowSimulationField
{
	public FluidForce force;
	[SerializeField]
	private Texture2D vectorTexture;
	public Texture2D attractVectorPreview;
	public Texture2D repulseVectorPreview;
	public Texture2D vortexClockwiseVectorPreview;
	public Texture2D vortexCounterClockwiseVectorPreview;
	public Texture2D directionalVectorPreview;
}
