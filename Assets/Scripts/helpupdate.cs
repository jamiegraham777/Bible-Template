using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helpupdate : MonoBehaviour {
    public Sprite helpmenu;
    public Sprite blnk;
	void Update () {
		if (counter.help == 1)
        {
            GetComponent<Image>().sprite = helpmenu;
        }
        if (counter.help == 0)
        {
            GetComponent<Image>().sprite = blnk;
        }
    }
}
