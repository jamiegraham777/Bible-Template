using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class intmarkg : MonoBehaviour
{
    public Sprite moff1;
    public Sprite mon1;

    void Update()
    {
        if (counter.camm == 1)
        {
            if (counter.count == 12)
            {
                GetComponent<Image>().sprite = moff1;
            }
            else
            {
                GetComponent<Image>().sprite = mon1;
            }
        }
        else
        {
            GetComponent<Image>().sprite = moff1;
        }
    }
}