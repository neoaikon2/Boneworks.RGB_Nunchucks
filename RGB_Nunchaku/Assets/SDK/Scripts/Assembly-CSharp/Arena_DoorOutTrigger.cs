using UnityEngine;
using System.Collections.Generic;
using StressLevelZero.AI;

public class Arena_DoorOutTrigger : MonoBehaviour
{
	[SerializeField]
	private List<TriggerRefProxy> enemyTriggerRefList;
	public int currEnemyCount;
	public bool playerInTrigger;
}
