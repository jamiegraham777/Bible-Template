using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intd1 : MonoBehaviour {
    void OnSelect()
    {
        if (counter.count >= 10)
        {
            counter.inter = 2;
        }
        else
        {
            counter.inter = 1;
        }
    }
}
