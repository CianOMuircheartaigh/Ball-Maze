using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerPlate : MonoBehaviour
{
    private bool _trigger = false;
    private bool _spike = false;

    [SerializeField]
    private GameObject _door;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_trigger == true)
        {
            Destroy(gameObject);
            Destroy(_door);
        }
        if (_spike == true)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "PressurePlate")
        {
            _trigger = true;
        }

        else
        {
            _trigger = false;
        }

        if (coll.gameObject.tag == "Spikes")
        {
            _spike = true;
        }

        else
        {
            _spike = false;
        }
    }
    }

