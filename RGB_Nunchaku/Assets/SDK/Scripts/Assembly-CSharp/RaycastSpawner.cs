using UnityEngine;

public class RaycastSpawner : MonoBehaviour
{
	[SerializeField]
	private LayerMask layers;
	[SerializeField]
	private GameObject Prefab;
	[SerializeField]
	private bool AttachToImpactObject;
}
