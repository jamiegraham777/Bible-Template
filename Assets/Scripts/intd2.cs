using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intd2 : MonoBehaviour {
    void OnSelect()
    {
        if (counter.count == 10)
        {
            counter.inter = 4;
        }
        else
        {
            counter.inter = 3;
        }
    }
}
