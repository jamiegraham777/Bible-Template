using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inttxt : MonoBehaviour {
    public Sprite blnk;
    public Sprite d1;
    public Sprite d2;
    public Sprite d3;
    public Sprite d4;
    public Sprite d5;
    public Sprite d6;
    public Sprite d7;
    public Sprite d8;
    public Sprite d9;
    public Sprite d10;
    public Sprite g11;
    public Sprite g12;
    public Sprite g13;
    public Sprite g14;
    public Sprite g15;
    public Sprite g16;
    public Sprite g17;
    public Sprite g18;
    public Sprite g19;
    public Sprite g20;
	void Update () {
		if (counter.inter == 1)
        {
            StartCoroutine(do1());
        }
        if (counter.inter == 2)
        {
            StartCoroutine(do2());
        }
        if (counter.inter == 3)
        {
            StartCoroutine(do3());
        }
        if (counter.inter == 4)
        {
            StartCoroutine(do4());
        }
        if (counter.inter == 5)
        {
            StartCoroutine(do5());
        }
        if (counter.inter == 6)
        {
            StartCoroutine(do6());
        }
        if (counter.inter == 7)
        {
            StartCoroutine(do7());
        }
        if (counter.inter == 8)
        {
            StartCoroutine(do8());
        }
        if (counter.inter == 9)
        {
            StartCoroutine(do9());
        }
        if (counter.inter == 10)
        {
            StartCoroutine(do10());
        }
        if (counter.inter == 11)
        {
            StartCoroutine(do11());
        }
        if (counter.inter == 12)
        {
            StartCoroutine(do12());
        }
        if (counter.inter == 13)
        {
            StartCoroutine(do13());
        }
        if (counter.inter == 14)
        {
            StartCoroutine(do14());
        }
        if (counter.inter == 15)
        {
            StartCoroutine(do15());
        }
        if (counter.inter == 16)
        {
            StartCoroutine(do16());
        }
        if (counter.inter == 17)
        {
            StartCoroutine(do17());
        }
        if (counter.inter == 18)
        {
            StartCoroutine(do18());
        }
        if (counter.inter == 19)
        {
            StartCoroutine(do19());
        }
        if (counter.inter == 20)
        {
            StartCoroutine(do20());
        }
    }
    IEnumerator do1()
    {
        GetComponent<Image>().sprite = d1;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do2()
    {
        GetComponent<Image>().sprite = d2;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do3()
    {
        GetComponent<Image>().sprite = d3;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do4()
    {
        GetComponent<Image>().sprite = d4;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do5()
    {
        GetComponent<Image>().sprite = d5;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do6()
    {
        GetComponent<Image>().sprite = d6;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do7()
    {
        GetComponent<Image>().sprite = d7;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do8()
    {
        GetComponent<Image>().sprite = d8;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do9()
    {
        GetComponent<Image>().sprite = d9;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do10()
    {
        GetComponent<Image>().sprite = d10;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do11()
    {
        GetComponent<Image>().sprite = g11;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do12()
    {
        GetComponent<Image>().sprite = g12;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do13()
    {
        GetComponent<Image>().sprite = g13;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do14()
    {
        GetComponent<Image>().sprite = g14;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do15()
    {
        GetComponent<Image>().sprite = g15;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do16()
    {
        GetComponent<Image>().sprite = g16;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do17()
    {
        GetComponent<Image>().sprite = g17;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do18()
    {
        GetComponent<Image>().sprite = g18;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do19()
    {
        GetComponent<Image>().sprite = g19;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }
    IEnumerator do20()
    {
        GetComponent<Image>().sprite = g20;
        yield return new WaitForSeconds(5);
        GetComponent<Image>().sprite = blnk;
        counter.inter = 0;
    }

}
