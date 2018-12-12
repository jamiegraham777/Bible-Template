using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intg5 : MonoBehaviour {
    void OnSelect()
    {
        if (counter.count >= 10)
        {
            counter.inter = 20;
        }
        else
        {
            counter.inter = 19;
        }
    }
}
