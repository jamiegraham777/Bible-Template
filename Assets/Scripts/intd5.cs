using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intd5 : MonoBehaviour {
    void OnSelect()
    {
        if (counter.count == 10)
        {
            counter.inter = 10;
        }
        else
        {
            counter.inter = 9;
        }
    }
}
