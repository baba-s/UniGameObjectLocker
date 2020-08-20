using UnityEditor;
using UnityEngine;

namespace Kogane.Internal
{
	internal static class GameBojectLocker
	{
		[MenuItem( "CONTEXT/Transform/Switch Lock - Unlock" )]
		private static void Lock( MenuCommand command )
		{
			var transform  = ( Transform ) command.context;
			var gameObject = transform.gameObject;

			gameObject.hideFlags ^= HideFlags.NotEditable;

			EditorUtility.SetDirty( gameObject );
		}
	}
}