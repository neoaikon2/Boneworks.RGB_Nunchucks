using UnityEngine;
using System.Collections.Generic;

public class LoadingScreenPackage : MonoBehaviour
{
	public float alpha;
	public List<ulong> overlayList;
	public bool ScaleWithCamera;
	public bool RotWithCamera;
	public Texture invisibleTexture;
	public Texture groundTexture;
	public Color renderModelColor;
	public Texture scalingTexture;
	public ulong scalingOverlayHandle;
	public float scaleSpeed;
	public float scaleMax;
	public float scaleMin;
}
