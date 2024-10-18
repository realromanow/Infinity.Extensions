using System;

namespace Infinity.Extensions {
	public static class ActionsExtensions {
		public static void RemoveAllListeners (this Action action) {
			var allInvokes = action?.GetInvocationList();

			if (allInvokes == null) return;

			foreach (var invoke in allInvokes) {
				var @delegate = Delegate.Remove(action, invoke);
			}
		}
		
		public static void RemoveAllListeners<T> (this Action<T> action) {
			var allInvokes = action?.GetInvocationList();

			if (allInvokes == null) return;

			foreach (var invoke in allInvokes) {
				var @delegate = Delegate.Remove(action, invoke);
			}
		}
	}
}
