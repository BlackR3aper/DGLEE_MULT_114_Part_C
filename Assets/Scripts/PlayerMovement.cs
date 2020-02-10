using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float verSpeed = 20;
    public float hozSpeed = 10;
// Start is called before the first frame update
void Start()
    {
        
    }
   //Have the vehicle accelerate, and control it
    void Update()
    {
     float verticalInput = Input.GetAxis("Vertical");
     float hortizontalInput = Input.GetAxis("Horizontal");
    transform.Translate (Vector3.forward * Time.deltaTime * verSpeed * verticalInput);
    //transform.Translate (Vector3.right * Time.deltaTime * hozSpeed * hortizontalInput);
    transform.Rotate(Vector3.up, Time.deltaTime * hozSpeed * hortizontalInput);
    }
}