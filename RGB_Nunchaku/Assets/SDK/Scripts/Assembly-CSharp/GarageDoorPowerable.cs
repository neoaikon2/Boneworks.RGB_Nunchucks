using UnityEngine;

public class GarageDoorPowerable : Powerable
{
	public enum MOVINGSTATE
	{
		UP = 0,
		DOWN = 1,
		STOPPED_UP = 2,
		STOPPED_DOWN = 3,
	}

	public bool isBinary;
	public GameObject GarageDoorParent;
	public Transform GarageTop;
	public Transform GarageBottom;
	public float MinMoveRate;
	public float MaxMoveRate;
	public float ConstantMoveRate;
	public float Speed;
	public float lowerOffSet;
	public float higherOffset;
	public float min_InputVoltage;
	public float max_InputVoltage;
	public float min_TargetVoltage;
	public float max_TargetVoltage;
	public bool isDebugging;
}
