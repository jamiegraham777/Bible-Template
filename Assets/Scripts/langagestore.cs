using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class langagestore : MonoBehaviour
{
    void OnSelect()
    {
        if (language.lang == 0)
        {
            language.lang = 1;
        }
        else
        {
            language.lang = 0;
        }
    }
}
