using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;
using StressLevelZero.AI;
using UnityEngine.Audio;

public class BossClawAi : MonoBehaviour
{
	public enum MentalState
	{
		Rest = 0,
		Patrol = 1,
		Pounce = 2,
		Unload = 3,
	}

	public enum PounceState
	{
		Charge = 0,
		Drop = 1,
		Scoop = 2,
		Check = 3,
	}

	[SerializeField]
	private NavMeshAgent _navAgent;
	[SerializeField]
	private Rigidbody _baseRb;
	[SerializeField]
	private ConfigurableJoint _jointBase;
	[SerializeField]
	private ConfigurableJoint _jointSpineA;
	[SerializeField]
	private ConfigurableJoint _jointSpineB;
	[SerializeField]
	private ConfigurableJoint _jointSpineC;
	[SerializeField]
	private ConfigurableJoint _jointCabin;
	[SerializeField]
	private GameObject[] _scoopObjects;
	[SerializeField]
	private Transform _boxCheck;
	public Transform unloadPoint;
	public Vector2 patrolXz;
	public float patrolFrequency;
	public float maxExtension;
	public float extensionTime;
	public float retractionTime;
	public float speed;
	public float acceleration;
	public float scoopSpringXz;
	public float scoopDamperXz;
	public float pounceSpeedMult;
	public float pounceAccelMult;
	public float pounceSpringMult;
	public float pounceDamperMult;
	public LayerMask preyLayers;
	public List<TriggerRefProxy> targetList;
	[SerializeField]
	private TriggerRefProxy _activeTarget;
	public AudioClip movementLoop;
	public AudioClip articulationLoop;
	public AudioClip charge;
	[SerializeField]
	private AudioClip _scoopOn;
	[SerializeField]
	private AudioClip _scoopOff;
	[SerializeField]
	private AudioMixerGroup _mixerGroup;
	[SerializeField]
	private MentalState _mentalState;
	[SerializeField]
	private MentalState _defaultState;
	[SerializeField]
	private PounceState _pounceState;
}
