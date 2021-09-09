using System;


namespace _mrstruijk.Events
{
	/// <summary>
	/// By Maarten R. Struijk Wilbrink
	/// </summary>
	public class ActionResponse : ResponseBase
	{
		public Action response;


		public override void OnEventRaised()
		{
			base.OnEventRaised();

			response?.Invoke();
		}
	}
}