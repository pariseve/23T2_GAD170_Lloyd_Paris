using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    //This car should be called an Audi
    [SerializeField] private string brand = "Audi";
    [SerializeField] private int speedLimit = 220;
    public bool isCrashed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
