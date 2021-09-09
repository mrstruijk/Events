using System.Collections;
using UnityEngine;


/// <summary>
///
/// By Maarten R. Struijk Wilbrink
/// </summary>
public class GameLoopEventsRaiser : MonoBehaviour
{
	[SerializeField] private EventSO onAwakeEvent;
	[SerializeField] private EventSO onStartEvent;

	[Space(10)]
	[SerializeField] private float afterStartDelay = 1f;
	[SerializeField] private EventSO afterStartEvent;

	[Space(10)]
	[SerializeField] private EventSO onUpdateEvent;

	[Space(10)]
	[SerializeField] private float everyXSeconds = 1f;
	[SerializeField] private EventSO everyXSecondsEvent;

	[Space(10)]
	[SerializeField] private EventSO onDisableEvent;
	[SerializeField] private EventSO onQuitEvent;


	private void Awake()
	{
		onAwakeEvent.Raise();
	}


	private void Start()
	{
		onStartEvent.Raise();
		StartCoroutine(AfterStartEvent());
		StartCoroutine(EveryXSecodsEvent());
	}


	private IEnumerator AfterStartEvent()
	{
		yield return new WaitForSeconds(afterStartDelay);
		afterStartEvent.Raise();
	}


	private void Update()
	{
		onUpdateEvent.Raise();
	}


	private IEnumerator EveryXSecodsEvent()
	{
		var sec = new WaitForSeconds(everyXSeconds);

		for (;;)
		{
			yield return sec;
			everyXSecondsEvent.Raise();
		}
	}


	private void OnDisable()
	{
		onDisableEvent.Raise();
		StopAllCoroutines();
	}


	private void OnApplicationQuit()
	{
		onQuitEvent.Raise();
	}
}
