using UnityEngine;
using Flowmap;

public class FlowSimulator : MonoBehaviour
{
	public int resolutionX;
	public int resolutionY;
	public SimulationBorderCollision borderCollision;
	public bool simulateOnPlay;
	public int maxSimulationSteps;
	public bool continuousSimulation;
	public string outputFolderPath;
	public string outputPrefix;
	public bool writeToFileOnMaxSimulationSteps;
}
