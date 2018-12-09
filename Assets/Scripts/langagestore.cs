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
	public void Hebrew()
	{
		language.lang = 1;
	}
	public void English()
	{
		language.lang = 0;
	}
}
