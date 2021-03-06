﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The list of every animation triggers that the character can do.
public enum PlayerMoveSet
{
    Null,
    Idle,
    Run,
    Jump,
    Fall,
    Land,
    Attack,
    Execution,
    Dodge
}

//List every Player Inpput names as written in the input manager
public enum PlayerInput
{
    Jump, // X
    Attack, // Square
    Execution, // Triangle
    Dodge // Circle
}


public class EntityBehaviour : MonoBehaviour {

    private Animator animator;

    public EntityStats entityS;
   
    //The state machine reference
    public DayFSM fsm;

    //Input buffer recorded for some milliseconds
    public DayInputBuffer inputBuffer;

    [HideInInspector]
    public Camera cam;

    [HideInInspector]
    public Rigidbody body;

    public LayerMask groundLayer;

    protected bool isGrounded = true;

    // Use this for initialization
    public virtual void Start () {
        animator = GetComponent<Animator>();
        cam = Camera.main;
        body = GetComponent<Rigidbody>();
        inputBuffer = new DayInputBuffer();
        
        if (fsm != null)
        {
            //Give player animator to state fsm
            fsm.animator = animator;
            fsm.entityB = this;
            fsm.Start();

            Debug.Log(this);
        }
    }
	
	// Update is called once per frame
	protected virtual void Update () {
        inputBuffer.Listen();
        fsm.Update();
        //Debug.Log("IsGrounded: " + CheckIsGround());
    }

    protected void FixedUpdate()
    {
        fsm.FixedUpdate();
    }

    public bool CheckIsGround()
    {
        isGrounded = Physics.CheckSphere(transform.position + Vector3.up * 0.3f, 0.5f, groundLayer.value); //Need to check Layer Mask
        return isGrounded;
    }
}
