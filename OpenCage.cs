using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCage : MonoBehaviour
{
    private bool _cage = false;
    [SerializeField]
    private GameObject cage1;
    [SerializeField]
    private GameObject cage2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_cage == true)
        {
            Destroy(cage1);
            Destroy(cage2);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Key")
        {
            _cage = true;
        }

        else
        {
            _cage = false;
        }
    }
}
