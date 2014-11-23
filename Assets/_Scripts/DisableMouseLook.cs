using UnityEngine;
using System.Collections;

public class DisableMouseLook : MonoBehaviour {

	// Use this for initialization
	void Start () {
		disableFPSControllerMouseLook ();
		disablePlayerCameraMouseLook ();
	}

	private void disableFPSControllerMouseLook() {
		GameObject fpsController = GameObject.Find ("First Person Controller");
		MouseLook mouseLook = (MouseLook)fpsController.GetComponent ("MouseLook");
		mouseLook.enabled = false;
	}

	private void disablePlayerCameraMouseLook() {
		GameObject playerCamera = GameObject.Find ("Main Camera");
		MouseLook mouseLook = (MouseLook)playerCamera.GetComponent("MouseLook");
		mouseLook.enabled = false;
	}
}
