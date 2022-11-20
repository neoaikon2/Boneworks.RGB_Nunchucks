using UnityEngine;
using UnityEngine.UI;

namespace Boneworks
{
	public class Control_TestEnvironment : MonoBehaviour
	{
		public bool guiOn;
		public Image[] hitMarkers_targetA;
		public Image[] hitMarkers_targetB;
		public Image[] hitMarkers_targetC;
		public Text targetA_Avg;
		public Text targetB_Avg;
		public Text targetC_Avg;
		public float fadeDuration;
		public Color32 storedColor;
		public Color32 droppedColor;
		public Color32 bullseyeColor;
		public Text bodyDisplayText;
		public Text heightDisplayText;
		public Text seatOffsetDisplayText;
		public Text activeHeightText;
		public Transform tempHeightObject;
		public Image heightMeter;
		public Text realHeightDisplayText;
		public Text characterHeightDisplayText;
		public Text sittingOffsetDisplayText;
		public Text ipdScaleDisplayText;
		public Text playerScaleDisplayText;
		public int bodyMode;
		public float characterHeight;
		public float realWorldHeight;
		public float sittingOffset;
		public Slider ipdScaleSlider;
		public bool bodyScale;
		public float noiseFilterAmount;
		public float shoulderingAmount;
		public float alignAmount;
		public Slider noiseFilterSlider;
		public Slider shoulderingSlider;
		public Slider alignSlider;
		public Text noiseFilterText;
		public Text shoulderText;
		public Text alignText;
		public Image debugToggleDot;
		public Text locomotionCurveText;
		public Sprite sprite_touchpad_linear;
		public Sprite sprite_touchpad_poles;
		public Sprite sprite_touchpad_octoWeight;
		public Sprite sprite_touchpad_octoStep;
		public Sprite sprite_touchpad_dpad;
		public Sprite sprite_touchpad_genesis;
		public Sprite sprite_touchpad_alex;
		public Image image_touchpad;
		public Text text_noiseONOFF;
		public Text text_shoulderONOFF;
		public Text text_alignONOFF;
		public Text text_locomotionDirection;
	}
}
