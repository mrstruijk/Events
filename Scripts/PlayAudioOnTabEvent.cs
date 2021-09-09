namespace _mrstruijk.Events
{
	public class PlayAudioOnTabEvent : BasePlayAudio
	{
		private void OnEnable()
		{
			EventSystem.OnOverseerTabClicked += ListenerAction;
		}

		private void OnDisable()
		{
			EventSystem.OnOverseerTabClicked -= ListenerAction;
		}
	}
}
