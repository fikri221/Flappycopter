using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		SingleTonSample single = SingleTonSample.InstanceCreation();
		single.DisplayMessage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
