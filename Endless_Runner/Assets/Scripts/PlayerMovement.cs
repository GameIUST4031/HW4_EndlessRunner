using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float PlayerSpeed = 2;
    public float HorizontalSpeed = 3;    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * PlayerSpeed*Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left*HorizontalSpeed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right*HorizontalSpeed*Time.deltaTime);
        }
    }
}
