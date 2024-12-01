using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighestScore : MonoBehaviour
{
    public int highestScore=0;
    // Start is called before the first frame update
    private void Awake()
    {
        // Ensure this object is not destroyed when loading a new scene
        highestScore++;
        Debug.Log(highestScore);
        Destroy(gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
