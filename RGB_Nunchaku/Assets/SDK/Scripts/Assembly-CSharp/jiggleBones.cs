using UnityEngine;

public class jiggleBones : MonoBehaviour
{
	public bool debugMode;
	public Transform targetBone;
	public Vector3 boneAxis;
	public float targetDistance;
	public float bStiffness;
	public float bMass;
	public float bDamping;
	public float bGravity;
	public bool SquashAndStretch;
	public float sideStretch;
	public float frontStretch;
}
