using UnityEngine;

namespace UnityEngine.EventSystems
{
	public class VRStandaloneInputModule : VRInputModule
	{
		public override void Process()
		{
		}

		[SerializeField]
		private string m_HorizontalAxis;
		[SerializeField]
		private string m_VerticalAxis;
		[SerializeField]
		private string m_SubmitButton;
		[SerializeField]
		private string m_CancelButton;
		[SerializeField]
		private float m_InputActionsPerSecond;
		[SerializeField]
		private bool m_AllowActivationOnMobileDevice;
	}
}
