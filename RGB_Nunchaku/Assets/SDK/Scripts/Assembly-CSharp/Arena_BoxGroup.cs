using UnityEngine;
using System.Collections.Generic;
using StressLevelZero.Arena;

public class Arena_BoxGroup : MonoBehaviour
{
	public List<Transform> bottomSpawnPointList;
	public List<Transform> middleSpawnPointList;
	public List<Transform> topSpawnPointList;
	public Arena_Volume triggerVolume;
	public bool isSpawning;
	public Arena_BoxGroup altGroup;
}
