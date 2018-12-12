using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapcamera : MonoBehaviour {
    public Camera dcam1;
    public Camera gcam1;
    public static Camera dcam;
    public static Camera gcam;
	void Start () {
        dcam = dcam1;
        gcam = gcam1;
        dcam.enabled = true;
        gcam.enabled = false;
	}
    private void Update()
    {
        if (counter.count == 13)
        {
            dcam.enabled = false;
            gcam.enabled = false;
        }
    }
}
