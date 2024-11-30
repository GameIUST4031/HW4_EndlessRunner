using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiisionDetect : MonoBehaviour
{
    private GameObject player;
    Animator animator_Collision;
    
    void OnTriggerEnter(Collider other)
    {
        player.GetComponent<PlayerMovement>().enabled = false;
        animator_Collision.speed = 2.5f;
        animator_Collision.Play("Stumble Backwards");
    }
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator_Collision = GameObject.FindGameObjectWithTag("EVE").GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
