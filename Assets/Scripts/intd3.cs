using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intd3 : MonoBehaviour {
    void OnSelect()
    {
        if (counter.count == 10)
        {
            counter.inter = 6;
        }
        else
        {
            counter.inter = 5;
        }
    }
}
