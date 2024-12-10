using System;
using UnityEngine;

[Serializable]
public class ControllKeys
{
    public KeyCode Forward;
    public KeyCode Back;
    public KeyCode Left;
    public KeyCode Right;
    public KeyCode Jump;
}


public class Player : MonoBehaviour
{
    [SerializeField]
    public ControllKeys controllKeys;
    private Rigidbody rb;

    void Update(){
        rb = GetComponent<Rigidbody>();
    }

    
}
