using UnityEngine;

public class PID_Controller : MonoBehaviour
{
	public Rigidbody rb;
	public ConfigurableJoint joint;
	public Transform followTran;
	public float pGain;
	public float iGain;
	public float dGain;
}
