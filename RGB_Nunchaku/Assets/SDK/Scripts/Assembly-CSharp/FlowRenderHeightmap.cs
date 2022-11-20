using Flowmap;
using UnityEngine;

public class FlowRenderHeightmap : FlowHeightmap
{
	public int resolutionX;
	public int resolutionY;
	public FluidDepth fluidDepth;
	public float heightMax;
	public float heightMin;
	public LayerMask cullingMask;
	public bool dynamicUpdating;
}
