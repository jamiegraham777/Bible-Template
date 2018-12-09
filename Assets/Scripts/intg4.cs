using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intg4 : MonoBehaviour {
    void OnSelect()
    {
        if (counter.count == 10)
        {
            counter.inter = 18;
        }
        else
        {
            counter.inter = 17;
        }
    }
}
