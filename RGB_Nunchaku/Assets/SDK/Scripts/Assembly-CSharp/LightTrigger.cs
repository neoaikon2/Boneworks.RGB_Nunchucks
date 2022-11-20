using UnityEngine;

public class LightTrigger : MonoBehaviour
{
	[SerializeField]
	private LayerMask LayerFilter;
	[SerializeField]
	private Light SourceLight;
	[SerializeField]
	private GameObject SourceLightTransform;
	[SerializeField]
	public Transform TargetTransform;
	[SerializeField]
	private float SpotLightAngle;
	[SerializeField]
	private float LightRange;
	[SerializeField]
	private float LightIntensity;
	[SerializeField]
	private Color LightColor;
	[SerializeField]
	public float OverallTransitionTime;
	[SerializeField]
	public float outTransitionTime;
	[SerializeField]
	public float inTransitionTime;
}
