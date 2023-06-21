using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KazukoChanger : MonoBehaviour
{
    [SerializeField] private GameObject kazuko, player, playerCamera;
   
   
    public void ChangeModelToKazuko()
    {
        kazuko.SetActive(true);
     
        kazuko.transform.position = player.transform.position;
        kazuko.transform.rotation = player.transform.rotation;
      
        player.SetActive(false);
        playerCamera.SetActive(false);
    }

    public void ChangeModelToPlayer()
    {
        player.SetActive(true);
        playerCamera.SetActive(true);
        kazuko.SetActive(false);

    }
    
}
