using UnityEngine;
using UnityEngine.UI;


namespace _mrstruijk.Events
{
	[RequireComponent(typeof(Button))]
	public class SubscribeOnOverseerButtonClicked : BaseSubscribeToEventSystem
	{
		private void OnEnable()
		{
			GetComponent<Button>().onClick.AddListener(InvokeAction);
		}


		public override void InvokeAction()
		{
			EventSystem.Invoke(EventSystem.OnOverseerButtonClicked);
		}


		private void OnDisable()
		{
			GetComponent<Button>().onClick.RemoveListener(InvokeAction);
		}
	}
}
