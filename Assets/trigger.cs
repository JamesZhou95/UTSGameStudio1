using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {

   public GameObject[] door;

	// Use this for initialization
	void OnTriggerEnter(Collider2D other)
   {
      if (other.CompareTag("trigger") || other.CompareTag("Player")){
         //door.Open();
      }
   }

   void OnTriggerExit(Collider other)
   {
      if (other.CompareTag("trigger") || other.CompareTag("Player")){
         //door.Close();
      }
   }
}
