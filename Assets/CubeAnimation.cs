using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimation : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            animator.SetBool("interakce", true);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            animator.SetBool("interakce", false);
        }
    }
}
