using UnityEngine;

public class RFX4_UVAnimation : MonoBehaviour
{
	public int TilesX;
	public int TilesY;
	public int FPS;
	public int StartFrameOffset;
	public bool IsLoop;
	public float StartDelay;
	public bool IsReverse;
	public bool IsInterpolateFrames;
	public RFX4_TextureShaderProperties[] TextureNames;
	public AnimationCurve FrameOverTime;
}
