using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    private Rigidbody _rb;
    private GameObject _bubble;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
        _bubble = GameObject.FindGameObjectWithTag("Bubble");
    }

    // Update is called once per frame
    void Update()
    {
        var position = _bubble.transform.position;
        // Debug.Log(position);
        _rb.transform.position = position;
    }
}
