﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clickcount : MonoBehaviour
{
    public AudioSource e1;
    public AudioSource e2;
    public AudioSource e3;
    public AudioSource e4;
    public AudioSource e5;
    public AudioSource e6;
    public AudioSource e7;
    public AudioSource e8;
    public AudioSource e9;
    public AudioSource e10;
    public AudioSource e11;
    public AudioSource e12;
    public AudioSource h1;
    public AudioSource h2;
    public AudioSource h3;
    public AudioSource h4;
    public AudioSource h5;
    public AudioSource h6;
    public AudioSource h7;
    public AudioSource h8;
    public AudioSource h9;
    public AudioSource h10;
    public AudioSource h11;
    public AudioSource h12;
    public void OnSelect()
    {
        counter.count++;
        if (counter.count == 1)
        {
            if (language.lang == 0)
            {
                e1.Play();
            }
            else
            {
                h1.Play();
            }
        }
        if (counter.count == 2)
        {
            e1.Stop();
            h1.Stop();
            if (language.lang == 0)
            {

                e2.Play();
            }
            else
            {
                h2.Play();
            }
        }
        if (counter.count == 3)
        {
            e2.Stop();
            h2.Stop();
            if (language.lang == 0)
            {

                e3.Play();
            }
            else
            {
                h3.Play();
            }
        }
        if (counter.count == 4)
        {
            e3.Stop();
            h3.Stop();
            if (language.lang == 0)
            {

                e4.Play();
            }
            else
            {
                h4.Play();
            }
        }
        if (counter.count == 5)
        {
            e4.Stop();
            h4.Stop();
            if (language.lang == 0)
            {

                e5.Play();
            }
            else
            {
                h5.Play();
            }
        }
        if (counter.count == 6)
        {
            e5.Stop();
            h5.Stop();
            if (language.lang == 0)
            {

                e6.Play();
            }
            else
            {
                h6.Play();
            }
        }
        if (counter.count == 7)
        {
            e6.Stop();
            h6.Stop();
            if (language.lang == 0)
            {

                e7.Play();
            }
            else
            {
                h7.Play();
            }
        }
        if (counter.count == 8)
        {
            e7.Stop();
            h7.Stop();
            if (language.lang == 0)
            {

                e8.Play();
            }
            else
            {
                h8.Play();
            }
        }
        if (counter.count == 9)
        {
            e8.Stop();
            h8.Stop();
            if (language.lang == 0)
            {

                e9.Play();
            }
            else
            {
                h9.Play();
            }
        }
        if (counter.count == 10)
        {
            e9.Stop();
            h9.Stop();
            if (language.lang == 0)
            {

                e10.Play();
            }
            else
            {
                h10.Play();
            }
        }
        if (counter.count == 11)
        {
            e10.Stop();
            h10.Stop();
            if (language.lang == 0)
            {

                e11.Play();
            }
            else
            {
                h11.Play();
            }
        }
        if (counter.count == 12)
        {
            e11.Stop();
            h11.Stop();
            if (language.lang == 0)
            {

                e12.Play();
            }
            else
            {
                h12.Play();
            }
        }
        if (counter.count > 12)
        {
            SceneManager.LoadScene("Main");
        }
    }
}