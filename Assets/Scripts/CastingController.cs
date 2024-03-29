﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingController : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        PlayerInputController.Instance.Cast += Cast;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Cast()
    {
        animator.SetTrigger("doCast");
    }
}
