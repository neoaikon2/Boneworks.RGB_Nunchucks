using UnityEngine;

public class GarageDoor_Phys_Powerable : Powerable
{
	public bool isBinary;
	public bool isMotorized;
	public float lowerOffSet;
	public float higherOffset;
	public float min_InputVoltage;
	public float max_InputVoltage;
	public float min_TargetVoltage;
	public float max_TargetVoltage;
	public ConfigurableJoint m_configJoint;
	public Rigidbody m_rb;
	public float parentScale;
	public float springPower;
	public float springFreeHandMod;
	public float damperPower;
	public float damperMod;
	public float motor_forcePower;
	public float free_forcePower;
	public float locked_forcePower;
	public float speedMod;
	public float startTarPos;
	public float tarPos_closed;
	public float tarPos_open;
	public Vector3 desiredPosition;
	public GameObject[] Slats;
	public bool Locked;
	public float lockBreakThresh;
	[SerializeField]
	private OcclusionPortal occlusionPortal;
	public bool isDebugging;
}
