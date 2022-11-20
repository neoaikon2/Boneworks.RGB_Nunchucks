using UnityEngine;

public class Enemy_Turret : MonoBehaviour
{
	public bool packed;
	public float alert_t;
	public float dodge_t;
	public bool canFlip;
	public bool flipWhileFolded;
	public float force_jump;
	public bool patrolling;
	public bool alert;
	public bool tipped;
	public bool dead;
	public float mod_targetForce;
	public float gun_targetForce;
	public float body_targetForce;
	public float health_check_t;
	public GameObject fx_Death;
	public GameObject gun;
	public GameObject body;
	public ConfigurableJoint jnt_leg_l;
	public ConfigurableJoint jnt_leg_r;
	public ConfigurableJoint jnt_legHinge_l;
	public ConfigurableJoint jnt_legHinge_r;
	public ConfigurableJoint jnt_spine_slide;
	public ConfigurableJoint jnt_leg_rear;
	public Vector3 com_packed;
	public Vector3 com_unpacked;
	public Vector3 com_unFlip;
	public float stability;
	public float stability_speed;
	public float MaxFlippedTime;
	public Collider coneOfVision;
	public Transform target;
	public bool aggro;
	public Transform dummyTarget;
	public float patrol_speed;
	public float patrol_spread;
	public Transform laserSight;
	public float max_sightRange;
	public AudioClip[] clips_idle;
	public AudioClip[] clips_alert;
	public AudioClip[] clips_patrol;
	public AudioClip[] clips_unPack;
	public AudioClip[] clips_pack;
	public AudioClip[] clips_speak;
	public AudioClip[] clips_death;
}
