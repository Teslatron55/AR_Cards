using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainTrig : MonoBehaviour
{

    public Animator anim;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /* if(Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("None"))
         {
             anim.Play("SphereAnim");
         }
        else if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("SphereAnim"))
         {
             anim.Play("None");
         }
        
         if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("UnityOpen"))
         {
             anim.Play("UnityClose");
         } */

        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("None"))
            {
                anim.Play("SphereAnim");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("SphereAnim"))
            {
                anim.Play("None");
            }
          
        }

    }
}
