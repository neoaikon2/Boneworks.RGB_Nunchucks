using UnityEngine;
using System.Collections.Generic;
using StressLevelZero.Interaction;
using StressLevelZero.Props.Weapons;

public class Zombie_PlayerTrigger : MonoBehaviour
{
	public enum TriggerType
	{
		START = 0,
		SPAWN = 1,
		DETACH = 2,
		CROWBAR_WARP = 3,
	}

	public TriggerType triggerType;
	public Arena_EnemyReference.EnemyType spawnType;
	public Transform spawnPoint;
	public List<Arena_EnemyReference> enemyRefs;
	public int maxSpawnAmount;
	public float minTimeBetweenSpawns;
	public bool canSpawn;
	public bool onStayAllowed;
	public LinkData linkData;
	[SerializeField]
	private InteractableHost crowbarHost;
	[SerializeField]
	private GameObject crowbarObj;
	public List<HandWeaponSlotReciever> weaponSlotRecieverList;
	[SerializeField]
	private GameObject playerRigObj;
	[SerializeField]
	private Transform crowbarSpawn;
	[SerializeField]
	private bool isCrowbarAtSpawn;
}
