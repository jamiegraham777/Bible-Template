using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intd4 : MonoBehaviour {
    void OnSelect()
    {
        if (counter.count >= 10)
        {
            counter.inter = 8;
        }
        else
        {
            counter.inter = 7;
        }
    }
}
