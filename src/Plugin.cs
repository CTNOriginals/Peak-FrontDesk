using BepInEx;
using BepInEx.Logging;

namespace FrontDesk;

// Here are some basic resources on code style and naming conventions to help
// you in your first CSharp plugin!
// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions
// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names
// https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/names-of-namespaces

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

