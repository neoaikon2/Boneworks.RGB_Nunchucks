using UnityEngine;

public class Powerable_Joint : Powerable
{
	public bool isBinary;
	public float cur_InputVoltage;
	public float min_InputVoltage;
	public float max_InputVoltage;
	[SerializeField]
	private bool _warpOnStart;
	[SerializeField]
	private bool _varyTargetPosition;
	[SerializeField]
	private Vector3 _minPosition;
	[SerializeField]
	private Vector3 _maxPosition;
	[SerializeField]
	private bool _varyTargetVelocity;
	[SerializeField]
	private Vector3 _minVelocity;
	[SerializeField]
	private Vector3 _maxVelocity;
	[SerializeField]
	private bool _varyPrismaticDrive;
	[SerializeField]
	private Vector3 _xMinSpringDamperForce;
	[SerializeField]
	private Vector3 _xMaxSpringDamperForce;
	[SerializeField]
	private bool _varyPrismaticY;
	[SerializeField]
	private Vector3 _yMinSpringDamperForce;
	[SerializeField]
	private Vector3 _yMaxSpringDamperForce;
	[SerializeField]
	private bool _varyPrismaticZ;
	[SerializeField]
	private Vector3 _zMinSpringDamperForce;
	[SerializeField]
	private Vector3 _zMaxSpringDamperForce;
	[SerializeField]
	private bool _varyTargetRotation;
	[SerializeField]
	private float _minDegreesX;
	[SerializeField]
	private float _maxDegreesX;
	[SerializeField]
	private bool _varyTargetAngVelocity;
	[SerializeField]
	private Vector3 _minAngVelocity;
	[SerializeField]
	private Vector3 _maxAngVelocity;
	[SerializeField]
	private bool _varyAngularDrive;
	[SerializeField]
	private Vector3 _xAngMinSpringDamperForce;
	[SerializeField]
	private Vector3 _xAngMaxSpringDamperForce;
	[SerializeField]
	private ConfigurableJoint jnt_this;
}
