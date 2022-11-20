using UnityEngine;

public class Powerable : MonoBehaviour
{
	[SerializeField]
	protected bool m_Powered;
	[SerializeField]
	protected bool m_TurnedOn;
	public float Discharge;
	public ElectricItem Electronic;
}
