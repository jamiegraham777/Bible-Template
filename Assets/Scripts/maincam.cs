using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class maincam : MonoBehaviour {
    // Update is called once per frame
    public Camera dcam2;
    public Camera gcam2;
    public static Camera dcam3;
    public static Camera gcam3;
    public Canvas can;
    void Start()
    {
        dcam3 = dcam2;
        gcam3 = gcam2;
    }
        void Update () {
		if (dcam3.enabled == true)
        {
            can.worldCamera = dcam2;
        }
        else
        {
            can.worldCamera = gcam2;
        }
	}
}
