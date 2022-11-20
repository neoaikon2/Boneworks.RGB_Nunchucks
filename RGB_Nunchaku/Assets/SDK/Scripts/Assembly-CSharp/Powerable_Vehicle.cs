using UnityEngine;

public class Powerable_Vehicle : Powerable
{
	public bool isBinary;
	public float cur_InputVoltage;
	public float min_InputVoltage;
	public float max_InputVoltage;
	public float min_TargetVoltage;
	public float max_TargetVoltage;
	[SerializeField]
	private float m_TargetVelocity;
	[SerializeField]
	private float m_MaxForce;
	[SerializeField]
	private float m_PositionDamper;
	public ConfigurableJoint jnt_to_rotate;
}
