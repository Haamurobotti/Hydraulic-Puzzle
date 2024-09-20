using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class HydraulicCotroller : MonoBehaviour
{
    Animator animator;
    public bool broken = false;
    // Start is called before the first frame update
    void Start()
    {
        animator= GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        crushing();
    }
    public void Break()
    {
        broken= true;
    }
    void crushing()
    {
        if (Input.GetKeyUp("s") && broken == false)
        {
            animator.SetTrigger("Crushing");
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(false);
            }
        }
        else if (Input.GetKeyDown("s") && broken == false)
        {
            animator.SetTrigger("Crushing");
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(true);
            }
        }

    }
}
