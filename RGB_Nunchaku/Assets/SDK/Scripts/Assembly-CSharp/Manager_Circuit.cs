using UnityEngine;
using System.Collections.Generic;

public class Manager_Circuit : MonoBehaviour
{
	public SurgeBox FuseBoxRef;
	public bool isPowerSource;
	public float MinimumVoltage;
	public float TotalVoltage;
	public List<PowerSocket> PowerSockets;
	public List<Powerable> Electronics;
	public bool SpecificPSMode;
}
