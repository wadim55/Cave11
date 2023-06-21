using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kazuko : MonoBehaviour
{
    private static readonly int Animation = Animator.StringToHash("animation");
    [SerializeField] private GameObject sword;
    [SerializeField] private GameObject[] cameras;
    [SerializeField] private Text numAnim, numCam;
    private Animator anim=>GetComponent<Animator>();
   

    public void KazukoAction()
    {
        var numA = Convert.ToInt32(numAnim.text);
      
    
        if (numA <= 0 || numA >= 29) return;
        anim.SetInteger(Animation, numA); 
    }

    public void KazukoRakurs()
    {
        var numC = Convert.ToInt32(numCam.text);
        if (numC <= -1 || numC >= 4) return;
        for (var i = 0; i < cameras.Length; i++)
        {
            cameras[i].SetActive(numC == i);
        }
    }

}
