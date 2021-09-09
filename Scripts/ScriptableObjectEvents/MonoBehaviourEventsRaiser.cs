using System.Collections;
using UnityEngine;


namespace _mrstruijk.Events
{
	/// <summary>
	///
	/// By Maarten R. Struijk Wilbrink
	/// </summary>
	public class MonoBehaviourEventsRaiser : MonoBehaviour
	{
		[SerializeField] private EventSO onAwakeEvent;
		[SerializeField] private EventSO onStartEvent;
		[SerializeField] private EventSO onEnableEvent;

		[Space(10)]
		[SerializeField] private float afterStartDelay = 1f;
		[SerializeField] private EventSO afterStartEvent;

		[Space(10)]
		[SerializeField] private EventSO onUpdateEvent;

		[Space(10)]
		[SerializeField] private float everyXSeconds = 1f;
		[SerializeField] private EventSO everyXSecondsEvent;

		[Space(10)]
		[SerializeField] private EventSO onQuitEvent;
		[SerializeField] private EventSO onDisableEvent;


		private void Awake()
		{
			if (!onAwakeEvent)
			{
				return;
			}

			onAwakeEvent.Raise();
		}


		private void OnEnable()
		{
			if (!onEnableEvent)
			{
				return;
			}

			onEnableEvent.Raise();
		}


		private void Start()
		{
			if (onStartEvent != null)
			{
				onStartEvent.Raise();
			}

			StartCoroutine(AfterStartEvent());
			StartCoroutine(EveryXSecondsEvent(everyXSeconds));
		}


		private IEnumerator AfterStartEvent()
		{
			yield return new WaitForSeconds(afterStartDelay);

			if (!afterStartEvent)
			{
				yield break;
			}

			afterStartEvent.Raise();
		}


		private void Update()
		{
			if (!onUpdateEvent)
			{
				return;
			}

			onUpdateEvent.Raise();
		}


		private IEnumerator EveryXSecondsEvent(float delay)
		{
			var sec = new WaitForSeconds(delay);

			for (;;)
			{
				yield return sec;

				if (!everyXSecondsEvent)
				{
					yield break;
				}

				everyXSecondsEvent.Raise();
			}
		}


		private void OnApplicationQuit()
		{
			if (!onQuitEvent)
			{
				return;
			}

			onQuitEvent.Raise();
		}


		private void OnDisable()
		{
			if (onDisableEvent != null)
			{
				onDisableEvent.Raise();
			}

			StopAllCoroutines();
		}
	}
}
