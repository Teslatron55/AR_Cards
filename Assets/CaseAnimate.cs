using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseAnimate : MonoBehaviour {

    public Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("None"))
        {
            anim.Play("CaseOpen");
        }
        else if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("CaseClose"))
        {
            anim.Play("CaseOpen");
        }
        else if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("CaseOpen"))
        {
            anim.Play("CaseClose");
        } */

        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("None"))
            {
                anim.Play("CaseOpen");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("CaseOpen"))
            {
                anim.Play("CaseClose");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("CaseClose"))
            {
                anim.Play("CaseOpen");
            }
        }

    }
}
