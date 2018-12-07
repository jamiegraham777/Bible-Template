using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DavidArmyCharge : MonoBehaviour {

    Animator anim;

    // Use this for initialization
    void Start()
    {
        
            anim = GetComponent<Animator>();
        StartCoroutine(IdleAnimation());
    }

    void RepeatIdleAnimation()
    {
        StartCoroutine(IdleAnimation());
    }

    private IEnumerator IdleAnimation()
    {
        anim.SetTrigger("DavidArmyCharge");
        yield return new WaitForSeconds(2.0f);
        RepeatIdleAnimation();
        yield return null;
    }
}
