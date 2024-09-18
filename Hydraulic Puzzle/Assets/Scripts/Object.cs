using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Jobs;

public class Object : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rigidbody2D;
    Quaternion objectRotation;
    public float timeToDestroy = 2.0f;
    bool destroyed = false;
    public ParticleSystem DestroyEffect;

    private AudioSource audioSource;
    public AudioClip clip;

   private Points points;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D= GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        points = GameObject.Find("PointManager").GetComponent<Points>();
    }

    // Update is called once per frame
    void Update()
    {

        //print("rotaatio" +  objectRotation.eulerAngles.z);
       
        if (destroyed == true)
        {
            timeToDestroy -= Time.deltaTime;
            if (timeToDestroy < 0) 
            { 
                TimerEnded(); 
            
            }
         
        }
        objectRotation = transform.rotation;
    }

    private void TimerEnded()
    {
        points.AddPoints();
        ParticleSystem particleSystem = Instantiate(DestroyEffect, rigidbody2D.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.collider.tag);
        Debug.Log(other.otherCollider.tag);
        if (other.collider.tag == "Press")
        {
            // Vector3 pos;
            // Quaternion rot;
            audioSource.Play();
            
            
            destroyed = true;
            if (objectRotation.eulerAngles.z >= 90 && objectRotation.eulerAngles.z <= 280)
            {
                animator.SetBool("IsSideways", true);
            }
            else
            {
                animator.SetBool("Idle", true);
            }

            
        }
        
    }
    
}
