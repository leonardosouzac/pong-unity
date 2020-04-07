using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAComputador : MonoBehaviour
{
    public Transform Ball;
    public float velocidade;
    private Rigidbody2D rbComp;
    // Start is called before the first frame update
    void Start()
    {
        rbComp = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbComp.velocity = new Vector2(0, (Ball.transform.position.y -  transform.position.y) * velocidade);

    }
}
