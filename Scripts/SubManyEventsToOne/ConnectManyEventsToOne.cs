using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public abstract class ConnectManyEventsToOne : MonoBehaviour
{
	private List<UnityEvent> responseEvent;

	public void Subscribe(UnityEvent subscriberEvent)
	{
		responseEvent ??= new List<UnityEvent>();

		if (responseEvent.Contains(subscriberEvent))
		{
			return;
		}

		responseEvent.Add(subscriberEvent);

		responseEvent[responseEvent.Count - 1].AddListener(ListenerAction);
	}


	public virtual void ListenerAction()
	{
		Debug.Log("Override this to subscribe your own method to be called. No need to call base.");
	}


	public void UnSubscribe(UnityEvent subscriberEvent)
	{
		if (!responseEvent.Contains(subscriberEvent))
		{
			return;
		}

		responseEvent[responseEvent.IndexOf(subscriberEvent)].RemoveListener(ListenerAction);
		responseEvent.Remove(subscriberEvent);
	}


	private void OnDisable()
	{
		for (int i = 0; i < responseEvent.Count; i++)
		{
			responseEvent[i].RemoveListener(ListenerAction);
		}
	}
}
