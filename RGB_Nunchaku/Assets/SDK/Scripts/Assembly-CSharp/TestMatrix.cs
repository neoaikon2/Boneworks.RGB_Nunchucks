using UnityEngine;

public class TestMatrix : MonoBehaviour
{
	public Transform slzHip;
	public Transform offsetHip;
	public Matrix4x4 offsetMatrix;
	public Matrix4x4 hipMatrix;
	public Matrix4x4 output;
	public Quaternion origRot;
	public Quaternion solvedRot;
	public Quaternion finalRot;
	public Matrix4x4 worldToLocal;
	public Matrix4x4 localToWorld;
}
