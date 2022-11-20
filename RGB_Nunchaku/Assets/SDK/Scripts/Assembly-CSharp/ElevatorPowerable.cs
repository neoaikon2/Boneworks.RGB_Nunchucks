using UnityEngine;

public class ElevatorPowerable : Powerable
{
	public bool isBinary;
	public float lowerOffSet;
	public float higherOffset;
	public float min_InputVoltage;
	public float max_InputVoltage;
	public float min_TargetVoltage;
	public float max_TargetVoltage;
	public ConfigurableJoint m_configJoint;
	public Rigidbody m_rb;
	public Rigidbody ConnectedRB;
	public float parentScale;
	public float springPower;
	public float damperPower;
	public float motor_forcePower;
	public float NoPowerForce;
	public float speedMod;
	public float tarPos_down;
	public float tarPos_up;
	public bool isDebugging;
}
