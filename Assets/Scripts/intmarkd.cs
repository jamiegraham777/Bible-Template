using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class intmarkd : MonoBehaviour
{
    public Sprite moff;
    public Sprite mon;

    void Update()
    {
        if (counter.camm == 0)
        {
            if (counter.count == 12)
            {
                GetComponent<Image>().sprite = moff;
            }
            else
            {
                GetComponent<Image>().sprite = mon;
            }
        }
        else
        {
            GetComponent<Image>().sprite = moff;
        }
    }
}