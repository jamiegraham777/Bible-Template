using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class button : MonoBehaviour {
    public Sprite e1;
    public Sprite e2;
    public Sprite e3;
    public Sprite e4;
    public Sprite e5;
    public Sprite e6;
    public Sprite e7;
    public Sprite e8;
    public Sprite e9;
    public Sprite e10;
    public Sprite e11;
    public Sprite e12;
    public Sprite h1;
    public Sprite h2;
    public Sprite h3;
    public Sprite h4;
    public Sprite h5;
    public Sprite h6;
    public Sprite h7;
    public Sprite h8;
    public Sprite h9;
    public Sprite h10;
    public Sprite h11;
    public Sprite h12;
    // Use this for initialization

    // Update is called once per frame
    void Update () {
        if (counter.count == 1)
        {
            if (language.lang == 0)
            {
                GetComponent<Image>().sprite = e1;
            }
            else
            {
                GetComponent<Image>().sprite = h1;
            }
            //Image theImage = GameObject.Find("txtbox").GetComponent<Image>();
            //theImage.sprite = one;​
        }
        if (counter.count == 2)
        {
            if (language.lang == 0)
            {
                GetComponent<Image>().sprite = e2;
            }
            else
            {
                GetComponent<Image>().sprite = h2;
            }
        }
    }
}
