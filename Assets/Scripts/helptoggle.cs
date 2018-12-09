using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helptoggle : MonoBehaviour
{
    public void OnSelect()
    {
        if (counter.help == 1) {
            counter.help = 0;
        }
        else
        {
            counter.help = 1;
        }
    }
}
