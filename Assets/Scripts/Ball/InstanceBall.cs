using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceBall : MonoBehaviour
{
    [SerializeField] GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Ball);
    }

    
}
