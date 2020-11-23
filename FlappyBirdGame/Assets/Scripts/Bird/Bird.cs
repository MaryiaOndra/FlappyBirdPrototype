using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BirdMover))]
public class Bird : MonoBehaviour
{
    private int _score;
    private BirdMover _mover;

    public int Score => _score;

    public event UnityAction GameOver;
    public event UnityAction ScoreChanged;

    private void Start()
    {
        _mover = GetComponent<BirdMover>();   
    }

    public void ResetPlayer() 
    {
        _score = 0;
        ScoreChanged?.Invoke();
        _mover.ResetBird();
    }

    internal void IcreaseScore()
    {
        _score++;
        ScoreChanged?.Invoke();
    }

    public void Die()
    {
        GameOver?.Invoke();
    }
}
