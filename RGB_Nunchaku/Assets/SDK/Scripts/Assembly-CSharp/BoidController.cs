using UnityEngine;

public class BoidController : MonoBehaviour
{
	public GameObject boidPrefab;
	public int spawnCount;
	public float spawnRadius;
	public float velocity;
	public float velocityVariation;
	public float rotationCoeff;
	public float neighborDist;
	public LayerMask searchLayer;
}
