using BepInEx;
using BepInEx.Logging;

namespace FrontDesk;

[BepInAutoPlugin]
public partial class Plugin : BaseUnityPlugin {
	internal static ManualLogSource Log { get; private set; } = null!;

	public static bool DebugMode = false; 

	private void Awake() {
#if DEBUG
		DebugMode = true;
#endif

		Log = Logger;
		Log.LogInfo($"Plugin {Name} ({Id}) {Version} is loaded! ({(DebugMode ? "Debug" : "Release")})");
	}

	private void Start() {
		SceneLoader.Start();
	}
}

