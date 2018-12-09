using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intg3 : MonoBehaviour {
    void OnSelect()
    {
        if (counter.count == 10)
        {
            counter.inter = 16;
        }
        else
        {
            counter.inter = 15;
        }
    }
}
