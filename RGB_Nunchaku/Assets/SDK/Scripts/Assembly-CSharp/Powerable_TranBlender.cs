using UnityEngine;

public class Powerable_TranBlender : Powerable
{
	public bool isBinary;
	public float cur_InputVoltage;
	public float min_InputVoltage;
	public float max_InputVoltage;
	public Transform[] ones;
	public Transform[] twos;
	public Transform[] writeTos;
}
