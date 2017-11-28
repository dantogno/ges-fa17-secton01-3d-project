using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IActivatable {
    private Animator animator;

    public void DoActivate()
    {
        animator.SetBool("isOpen", true);
    }

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
	}
}
