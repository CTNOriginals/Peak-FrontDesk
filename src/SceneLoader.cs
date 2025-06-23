using FrontDesk.Utils;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FrontDesk;

public static class SceneLoader {
	// private static bool _initialStartup = true;
	public static bool LoadedIslandStartup = true;

	public static void Start() {
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	public static void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
		CLogger.LogInfo($"Scene Loaded: {scene.name} | {mode}");

		if (scene.name == "Airport") {
			GameObject desk = GameObject.Find("Map/BL_Airport/Fences/Check In desk/AirportGateKiosk");
			GameObject kiosk = GameObject.Find("Map/BL_Airport/Fences/Kiosk (2)");
			CLogger.LogInfo($"{desk.name} | {desk.transform.position}");
			CLogger.LogInfo($"{kiosk.name} | {kiosk.transform.position}");

			desk.transform.position = new Vector3(-11, 1.5f, 52.5f);
			desk.transform.eulerAngles = new Vector3(270, 0, 0);
			
			kiosk.transform.position = new Vector3(-8, 1.5f, 52.5f);
			kiosk.transform.eulerAngles = new Vector3(270, 180, 0);
		}
	}
}


//> Map/BL_Airport/Fences/Check In desk/AirportGateKiosk
//* Pos: -11 1,5 52,5
//* Local: -1,2676 0,394 20,8579
//* Rot: 270 180 0

//> Map/BL_Airport/Fences/Kiosk (2)
//* Pos: -8 1,5 52,5
