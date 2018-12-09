using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class swapaction : MonoBehaviour
{
    void OnSelect()
    {
        swapcamera.dcam.enabled = !swapcamera.dcam.enabled;
        swapcamera.gcam.enabled = !swapcamera.gcam.enabled;
        if (counter.camm == 1) {
            counter.camm = 0;
        }
        else
        {
            counter.camm = 1;
        }
    }
}
