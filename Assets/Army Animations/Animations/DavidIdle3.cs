using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DavidIdle3 : MonoBehaviour {

    Animator anim;

    // Use this for initialization
    void Start()
    {
        if (counter.count == 0)
        anim = GetComponent<Animator>();
        StartCoroutine(IdleAnimation());
    }

    void RepeatIdleAnimation()
    {
        StartCoroutine(IdleAnimation());
    }

    private IEnumerator IdleAnimation()
    {
        anim.SetTrigger("DavidIdle3");
        yield return new WaitForSeconds(2.5f);
        RepeatIdleAnimation();
        yield return null;
    }
}
