using UnityEngine;

public class RopeMaxTensionHandler : MonoBehaviour
{
	[SerializeField]
	private float _lengthThreshold;
	[SerializeField]
	public string _maxTensionStartCallMethod;
	[SerializeField]
	public string _maxTensionEndCallMethod;
	[SerializeField]
	public string _maxTensionContinueCallMethod;
	[SerializeField]
	public GameObject _eventCallGameObject;
	[SerializeField]
	public bool _fixHaywire;
	[SerializeField]
	public bool _makeEndDynamicOnMaxTension;
}
