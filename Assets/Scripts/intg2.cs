using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intg2 : MonoBehaviour {
    void OnSelect()
    {
        if (counter.count == 10)
        {
            counter.inter = 14;
        }
        else
        {
            counter.inter = 13;
        }
    }
}
