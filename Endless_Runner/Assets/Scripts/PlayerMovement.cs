using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float PlayerSpeed = 2;
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * PlayerSpeed*Time.deltaTime);
    }
}
