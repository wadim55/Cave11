using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Bomb : Sound
{ 
   
   [SerializeField] private GameObject exlosion;
  [SerializeField] private Material decail;
   void OnTriggerEnter(Collider col)
   {
      if (col.gameObject.tag == "Player")
      {
         ItemEvents.itemExploded(gameObject);
         PlaySound(1);
         exlosion.SetActive(true);
         GetComponent<Renderer>().material = decail;
         Destroy(gameObject, 0.4f);
      }

   }
}
