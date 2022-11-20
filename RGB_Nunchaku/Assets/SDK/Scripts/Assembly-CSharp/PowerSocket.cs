using UnityEngine;

public class PowerSocket : MonoBehaviour
{
	[SerializeField]
	private float m_ChargeCurrent;
	public bool Charging;
	[SerializeField]
	private PowerSource SamePower;
	public GameObject[] indicateOn;
	public GameObject[] indicateOff;
}
