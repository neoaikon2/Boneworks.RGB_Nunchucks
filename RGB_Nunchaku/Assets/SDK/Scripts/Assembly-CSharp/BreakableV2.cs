using UnityEngine;

public class BreakableV2 : MonoBehaviour
{
	public bool UseCollisionForce;
	public float CollisionForce;
	public bool UseHp;
	public float MaxHp;
	public AudioClip[] CollisionSounds;
	public bool UseThisObject;
	public Transform[] CollisionPrefabs;
	public float CollisionEffectDuration;
	public AudioClip[] BreakingSounds;
	public Transform[] BrokenPrefabs;
	public float BreakDelay;
	public Transform[] AfterDelayBrokenPrefabs;
	public bool ApplyExplosionForce;
	public float ExplosionForce;
	public float ExplosionRadius;
	public bool CanReset;
	public bool UseAutoDestruct;
	public float AutoDestructTimer;
	public float currentHp;
	public bool broken;
	public float delayTimer;
	public float destructionTimer;
}
