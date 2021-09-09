namespace _mrstruijk.Events
{
	public class PlayAudioOnButtonEvent : BasePlayAudio
	{
		private void OnEnable()
		{
			EventSystem.OnOverseerButtonClicked += ListenerAction;
		}

		private void OnDisable()
		{
			EventSystem.OnOverseerButtonClicked -= ListenerAction;
		}
	}
}
