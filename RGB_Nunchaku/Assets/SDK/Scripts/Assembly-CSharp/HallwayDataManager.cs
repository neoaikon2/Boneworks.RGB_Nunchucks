using UnityEngine;
using StressLevelZero.Props;

public class HallwayDataManager : MonoBehaviour
{
	[SerializeField]
	private bool visDebug;
	[SerializeField]
	private HallwayData _data;
	[SerializeField]
	private GameObject[] destObjects;
	[SerializeField]
	private ObjectDestructable[] destructables;
	[SerializeField]
	private GameObject[] inDestObjects;
	[SerializeField]
	private int currCustomGroup;
	[SerializeField]
	private int currDefinedGroup;
}
