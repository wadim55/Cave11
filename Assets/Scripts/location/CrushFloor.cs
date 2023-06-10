using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrushFloor : MonoBehaviour
{
   [SerializeField] private GameObject floor, crushfloor;

   
   [ContextMenu("краш")]
   public void Crush()
   {
       floor.SetActive(false);
       crushfloor.SetActive(true);
   }
}
