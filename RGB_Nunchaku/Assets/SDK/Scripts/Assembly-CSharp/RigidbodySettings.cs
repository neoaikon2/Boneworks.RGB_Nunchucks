using UnityEngine;

public class RigidbodySettings : MonoBehaviour
{
	public bool scaleMass;
	public Transform comOverride;
	public float maxAv;
	public float iTensorMult;
	public bool normalizeTensor;
	public bool ignoreHierarchy;
	public bool drawCom;
	public bool resetOnEnable;
	public Collider[] localColliders;
	public Collider[] collidersToIgnore;
}
