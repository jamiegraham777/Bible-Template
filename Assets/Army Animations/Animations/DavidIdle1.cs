﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DavidIdle1 : MonoBehaviour {

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
        anim.SetTrigger("DavidIdle1");
        yield return new WaitForSeconds(1.0f);
        RepeatIdleAnimation();
        yield return null;
    }
}