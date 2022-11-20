using UnityEngine;

public class SwitchFog : MonoBehaviour
{
	[SerializeField]
	private float timeToFade;
	[SerializeField]
	private Gradient LocalGradient;
	[SerializeField]
	private float startDistance;
	[SerializeField]
	private float endDistance;
	[SerializeField]
	private int textureWidth;
	public Color heightFogColor;
	public float heightFogThickness;
	public float heightFogFalloff;
	public float heightFogBaseHeight;
}
