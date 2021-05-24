using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelotaudiocontroll : MonoBehaviour
{
       AudioSource[] sources;
       Rigidbody rb;
       float speed = 0.0f;
      bool isPlaying = false; 
    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent<Rigidbody>();
    sources = GetComponents<AudioSource>();
    sources[0].Play();   
    }

    // Update is called once per frame
    void Update()
    {
     speed = rb.velocity.magnitude;
     if (speed > 0.0f) {  
      sources[0].Play();   
    } else {
      sources[0].Stop();   
    }
  sources[0].pitch = speed / 4.0f;
  
    }
  // método llamada por Unity cuando chocamos con algo ... 

  void OnCollisionEnter(Collision   collision)
       {
        print("collision");
        sources[1].Play(); }

}
