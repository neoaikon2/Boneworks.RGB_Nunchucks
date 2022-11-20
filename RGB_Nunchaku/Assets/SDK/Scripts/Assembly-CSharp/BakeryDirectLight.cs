using UnityEngine;

public class BakeryDirectLight : MonoBehaviour
{
	public Color color;
	public float intensity;
	public float shadowSpread;
	public int samples;
	public int bitmask;
	public bool bakeToIndirect;
	public bool shadowmask;
	public bool shadowmaskDenoise;
	public float indirectIntensity;
	public int UID;
}
