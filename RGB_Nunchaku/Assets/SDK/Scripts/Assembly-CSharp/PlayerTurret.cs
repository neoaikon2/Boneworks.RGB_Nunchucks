using UnityEngine;
using StressLevelZero.Props.Weapons;

public class PlayerTurret : MonoBehaviour
{
	[SerializeField]
	private Gun leftGun;
	[SerializeField]
	private Gun rightGun;
	[SerializeField]
	private GameObject platformObj;
	[SerializeField]
	private float hoverForce;
}
