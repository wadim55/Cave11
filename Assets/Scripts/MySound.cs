using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySound : MonoBehaviour
{
    [SerializeField] private AudioClip[] music;

   private void Start()
   {
       LibrarySound.clip = music;
   }

    
}
