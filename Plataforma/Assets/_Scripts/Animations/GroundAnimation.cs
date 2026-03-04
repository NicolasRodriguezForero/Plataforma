using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundAnimation : MonoBehaviour
{
    public Animator anim;
    public bool isTouching;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            anim.SetTrigger("Touch");
        }
        
    }
}
