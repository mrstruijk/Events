using UnityEngine;


namespace _mrstruijk.Events
{
	[RequireComponent(typeof(TabButton))]
	public class SubscribeOnOverseerTabClicked : BaseSubscribeToEventSystem
	{
		private void OnEnable()
		{
			GetComponent<TabButton>().OnTabSelected.AddListener(InvokeAction);
		}

		public override void InvokeAction()
		{
			EventSystem.Invoke(EventSystem.OnOverseerTabClicked);
		}

		private void OnDisable()
		{
			GetComponent<TabButton>().OnTabSelected.RemoveListener(InvokeAction);
		}
	}
}
