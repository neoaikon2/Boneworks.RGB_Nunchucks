using UnityEngine;
using System.Collections.Generic;

public class RFX4_TransformMotion : MonoBehaviour
{
	public float Distance;
	public float Speed;
	public float Dampeen;
	public float MinSpeed;
	public float TimeDelay;
	public LayerMask CollidesWith;
	public GameObject[] EffectsOnCollision;
	public float CollisionOffset;
	public float DestroyTimeDelay;
	public bool CollisionEffectInWorldSpace;
	public GameObject[] DeactivatedObjectsOnCollision;
	public float HUE;
	public List<GameObject> CollidedInstances;
}
