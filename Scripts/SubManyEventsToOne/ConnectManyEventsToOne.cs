using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public abstract class ConnectManyEventsToOne : MonoBehaviour
{
	private List<UnityEvent> responseEvents;


	public void Subscribe(UnityEvent subscriberEvent)
	{
		responseEvents ??= new List<UnityEvent>();

		if (responseEvents.Contains(subscriberEvent))
		{
			return;
		}

		responseEvents.Add(subscriberEvent);

		responseEvents[responseEvents.Count - 1].AddListener(ListenerAction);
	}


	public virtual void ListenerAction()
	{
		Debug.Log("Override this to subscribe your own method to be called. No need to call base.");
	}


	public void UnSubscribe(UnityEvent subscriberEvent)
	{
		if (!responseEvents.Contains(subscriberEvent))
		{
			return;
		}

		responseEvents[responseEvents.IndexOf(subscriberEvent)].RemoveListener(ListenerAction);
		responseEvents.Remove(subscriberEvent);
	}


	private void OnDisable()
	{
		foreach (var response in responseEvents)
		{
			response.RemoveListener(ListenerAction);
		}
	}
}
