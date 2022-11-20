using UnityEngine;

public class DoorControl : MonoBehaviour
{
	public bool FreeDoor;
	public Vector3 axis_Link;
	public Vector3 axis_LinkSecondary;
	public bool DoorIndestructible;
	public float health_Door;
	public float DoorDurability;
	public bool damageFromImpact;
	public float thr_Impact;
	public float mod_Impact;
	public bool damageFromAttack;
	public float mod_Attack;
	public int req_hit_count;
	public bool LockIndestructible;
	public bool Lock_Locked;
	public bool Lock_Closed;
	public float health_Lock;
	public float LockDurability;
	public bool hasKey;
	public GameObject PhysicalLock;
	public Rigidbody rb_parent;
	public Transform override_Anchor;
	public bool UsingThresholds;
	public int SpringLoc;
	public float[] SpringAngles;
	public float[] thr_SpringAngle_UP;
	public float[] thr_SpringAngle_DOWN;
	public float SpringStrength;
	public float SpringDamper;
	public bool LimitsOn;
	public float LimitMax;
	public float LimitMin;
	public bool FlipLatch;
	public GameObject DoorKnob;
	[SerializeField]
	private float KnobThreshOffset;
	public float[] knob_UnlockAngles;
	public float knob_LimitMax;
	public float knob_LimitMin;
	public bool bool_springOpen;
	public int tar_springLoc;
	public AudioClip[] clip_Knock;
	public AudioClip[] clip_DoorDamage;
	public AudioClip[] clip_DoorDestroyed;
	public AudioClip[] clip_Knob;
	public AudioClip[] clip_Unlock;
	public AudioClip[] clip_LockDestroyed;
	public AudioClip[] clip_IsLocked;
	public AudioClip[] clip_SetLock;
	public ParticleSystem KnockParticles;
	public ParticleSystem DamageParticles;
	public GameObject fx_LockShatter;
	public GameObject fx_DoorShatter;
	public DoorLightControl[] DoorLights;
	public OcclusionPortal occlusionPortal;
}
