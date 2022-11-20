using UnityEngine;

public class Control_SurgeBox : SurgeBox
{
	public Vector3 axis_Link;
	public Vector3 axis_LinkSecondary;
	[SerializeField]
	private ConfigurableJoint m_lever;
	[SerializeField]
	private ConfigurableJoint m_closeBttn;
	[SerializeField]
	private ConfigurableJoint m_openBttn;
	[SerializeField]
	private Rigidbody rb_parent;
	[SerializeField]
	private Rigidbody rb_closeBttn;
	[SerializeField]
	private Rigidbody rb_openBttn;
	public Transform override_Anchor;
	public bool UsingThresholds;
	public int SpringLoc;
	public float[] SpringAngles;
	public float SpringStrength;
	public float SpringDamper;
	public float LimitMax;
	public float LimitMin;
	public float parentScale;
	public float springPower;
	public float damperPower;
	public float tarPos_pressedOpen;
	public float tarPos_pressedClosed;
	public float targPos_restOpen;
	public float tarPos_restClosed;
	public GameObject ChargedCard;
	public GameObject DischargedCard;
	public GameObject OpenCard;
	public GameObject ClosedCard;
	[SerializeField]
	private int m_leverTries;
	[SerializeField]
	private bool m_fuseIn;
	[SerializeField]
	private float m_highLeverLimit;
}
