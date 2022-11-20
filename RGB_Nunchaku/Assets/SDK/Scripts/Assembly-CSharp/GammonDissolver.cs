using UnityEngine;
using StressLevelZero.Interaction;
using StressLevelZero.Pool;
using UnityEngine.Events;

public class GammonDissolver : MonoBehaviour
{
	public Grip grip;
	public Poolee poolee;
	public UnityEvent onDespawned;
	public AudioClip despawnClip;
}
