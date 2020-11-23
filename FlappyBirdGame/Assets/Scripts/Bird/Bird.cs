using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BirdMover))]
public class Bird : MonoBehaviour
{
    private int _score;
    private BirdMover _mover;

    private void Start()
    {
        _mover = GetComponent<BirdMover>();   
    }

    public void ResetPlayer() 
    {
        _score = 0;
        _mover.ResetBird();
    }

    public void Die()
    {
        Debug.Log("I AM DEAD!");
        Time.timeScale = 0;
    }
}
