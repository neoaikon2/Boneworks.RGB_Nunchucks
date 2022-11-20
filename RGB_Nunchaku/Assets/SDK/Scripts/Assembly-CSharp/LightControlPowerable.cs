using UnityEngine;

public class LightControlPowerable : Powerable
{
	public bool isBinary;
	public bool Flicker;
	public float min_InputVoltage;
	public float max_InputVoltage;
	public float cur_InputVoltage;
	public float min_LightVoltage;
	public float max_LightVoltage;
	public float min_EmissiveVoltage;
	public float max_EmissiveVoltage;
	public Renderer mat_Renderer;
	public Renderer mat_haloRenderer;
	public float per_Blink;
	public Color hdr_OnColor;
	public Color hdr_OffColor;
	public Light light_Actual;
	public Color color_LightOn;
	public Color color_LightOff;
}
