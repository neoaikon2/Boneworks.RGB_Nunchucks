using UnityEngine;

public class DistortEffect : MonoBehaviour
{
	public enum Quality
	{
		High = 0,
		Medium = 1,
		Low = 2,
		Off = 3,
	}

	[SerializeField]
	private DistortCamera _distortCamera;
	[SerializeField]
	private LayerMask _distortLayers;
	[SerializeField]
	private Quality _distortQuality;
	[SerializeField]
	private bool _distortFadeEnabled;
	[SerializeField]
	private float _distortFadeStart;
	[SerializeField]
	private float _distortFadeEnd;
	[SerializeField]
	private bool _blurEnabled;
	[SerializeField]
	private bool _blurUseSGX;
	[SerializeField]
	private int _blurDownsample;
	[SerializeField]
	private float _blurSize;
	[SerializeField]
	private int _blurIterations;
}
