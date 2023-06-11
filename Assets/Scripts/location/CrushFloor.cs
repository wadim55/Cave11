using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrushFloor : Sound
{
   [SerializeField] private GameObject floor, crushfloor;

   private void OnEnable()
   {
       ItemEvents.itemExploded += Crush;
   }

   private void OnDisable()
   {
       ItemEvents.itemExploded -= Crush;
   }

   void Start()
   {
       floor.SetActive(true);
       crushfloor.SetActive(false);
   }
   
   
   [ContextMenu("краш")]
   public void Crush(GameObject a)
   {
       if (!((floor.transform.position - a.transform.position).magnitude < 5)) return;
       floor.SetActive(false);
       crushfloor.SetActive(true);
       PlaySound(0, 0.4f, 1 );

   }
}
