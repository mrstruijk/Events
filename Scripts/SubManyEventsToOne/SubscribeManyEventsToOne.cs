using UnityEngine;
using UnityEngine.Events;


public abstract class SubscribeManyEventsToOne : MonoBehaviour
{
	private ConnectManyEventsToOne connectManyEventsToOne;
	protected UnityEvent singleEvent;
}
