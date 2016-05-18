﻿using UnityEngine;
using System.Collections;

public class InputController: MonoBehaviour {
	public SteamVR_LaserPointer _laserPointer;

	public static SteamVR_Controller.Device rightController {
		get {
			return SteamVR_Controller.Input (SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Rightmost));
		}
	}
	public static SteamVR_LaserPointer laserPointer {
		get {
			return instance._laserPointer;
		}
	}

	private static InputController instance;

	void Start() {
		instance = this;
	}
}
