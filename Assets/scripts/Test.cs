using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject platform;
    Renderer platformRenderer,cube;
    public int upwardForce;
    void Start()
    {
        platformRenderer = platform.GetComponent<Renderer>();
        cube = GetComponent<Renderer>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(new Vector3(0, upwardForce, 0));       
        cube.material.color= Color.HSVToRGB(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        platformRenderer.material.color = Color.HSVToRGB(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }
    // Update is called once per frame
    
}
