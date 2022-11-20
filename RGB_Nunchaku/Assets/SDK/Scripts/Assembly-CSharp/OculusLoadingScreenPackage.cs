using UnityEngine;
using System.Collections.Generic;

public class OculusLoadingScreenPackage : MonoBehaviour
{
	public float alpha;
	public List<ulong> overlayList;
	public bool ScaleWithCamera;
	public bool RotWithCamera;
	public Texture invisibleTexture;
	public Texture groundTexture;
	public OVROverlay overlay;
	public Color renderModelColor;
	public Texture scalingTexture;
	public float scaleSpeed;
	public float scaleMax;
	public float scaleMin;
}
