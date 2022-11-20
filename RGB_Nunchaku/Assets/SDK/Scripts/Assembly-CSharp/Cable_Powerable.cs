using StressLevelZero.Interaction;
using UnityEngine;

public class Cable_Powerable : Powerable
{
	private enum CableMode
	{
		BIDIRECTIONAL = 0,
		ON_OFF = 1,
	}

	public CylinderGrip m_grip;
	public Renderer m_rend;
	public Transform m_CableMesh;
	[SerializeField]
	private CableMode m_Mode;
	public bool isBinary;
	public float lowerOffSet;
	public float higherOffset;
	public float min_InputVoltage;
	public float max_InputVoltage;
	public float min_TargetVoltage;
	public float max_TargetVoltage;
}
