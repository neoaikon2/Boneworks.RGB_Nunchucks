using Flowmap;
using UnityEngine;

public class ShallowWaterSimulator : FlowSimulator
{
	public int updateTextureDelayCPU;
	public float timestep;
	public float evaporationRate;
	public float gravity;
	public float velocityScale;
	public float fluidAddMultiplier;
	public float fluidRemoveMultiplier;
	public float fluidForceMultiplier;
	public float initialFluidAmount;
	public FluidDepth fluidDepth;
	public float outputAccumulationRate;
	public float outputFilterStrength;
	public bool simulateFoam;
	public float foamVelocityScale;
	public bool simulateFirstFluidHit;
	public float firstFluidHitTimeMax;
	public Material[] assignFlowmapToMaterials;
	public bool assignFlowmap;
	public string assignedFlowmapName;
	public bool assignHeightAndFluid;
	public string assignedHeightAndFluidName;
	public bool assignUVScaleTransform;
	public string assignUVCoordsName;
	public bool writeHeightAndFluid;
	public bool writeFoamSeparately;
	public bool writeFluidDepthInAlpha;
}
