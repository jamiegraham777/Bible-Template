using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intg1 : MonoBehaviour
{
    void OnSelect()
    {
        if (counter.count >= 10)
        {
            counter.inter = 12;
        }
        else
        {
            counter.inter = 11;
        }
    }
}
