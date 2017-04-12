using UnityEngine;
using System.Collections;

public class TorchFollow : MonoBehaviour {

   GameObject player;
   Vector3 offset;

   void Awake()
   {
      player = GameObject.FindGameObjectWithTag("Player");
   }

	void Start () {
      offset = this.transform.position - player.transform.position;
	}
	
	void Update () {
      this.transform.position = player.transform.position + offset;
	}
}
