using UnityEngine;
using StressLevelZero.Data;

public class PropSpawner : MonoBehaviour
{
	public Rigidbody rb;
	public Collider[] ignoreColliders;
	public Rigidbody headRb;
	public Vector3 localPosOffset;
	public Vector3 localRotOffset;
	public SpawnableObject headObject;
	public SpawnableObject altHeadObject;
	[SerializeField]
	private GameObject gO;
	public bool isAltObj;
	public bool _hasBeenSpawnedOnce;
	public bool spawnOnEnable;
	public bool despawnDetachedProp;
}
