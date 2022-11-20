using UnityEngine;

public class ZombieAI : MonoBehaviour
{
	public enum AttentionProperty
	{
		Nothing = 0,
		Idling = 1,
		Curious = 2,
		Destroy = 3,
		Eat = 4,
		GiveUp = 5,
		ShutDown = 6,
	}

	public bool notInAction;
	public Transform RespawnPoint;
	public bool active_absoluteOverride;
	public bool active_attention;
	public bool isHungry;
	public bool isInterested;
	public bool isDead;
	public float health_max;
	public float health_current;
	public float bleedOut;
	public float healUp;
	public float aggressionLevel_start;
	public float aggressionLevel_current;
	public float wantLevel_start;
	public float wantLevel_current;
	public float difficultyLevel_start;
	public float difficultyLevel_current;
	public Transform target_absoluteOverride;
	public Transform target_attention;
	public Transform target_default;
	public float attention_visualDistance;
	public float attention_auditoryDistance;
	public float attention_sixSenseDistance;
	public AttentionProperty ActiveAttentionProperty;
	public Transform standingZapperLocation;
	public ParticleSystem p_ZombieZapper;
}
