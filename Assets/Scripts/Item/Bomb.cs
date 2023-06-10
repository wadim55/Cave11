using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : Item
{

   void OnTriggerEnter(Collider col)
   {
      if (col.gameObject.tag == "Player")
      {
         ItemEvents.itemExploded(gameObject);
      }
   }
}
