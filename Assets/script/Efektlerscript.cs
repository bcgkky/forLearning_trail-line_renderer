using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efektlerscript : MonoBehaviour
{
    /*TrailRenderer trailefekt;
    public int speed;*/

    LineRenderer line;
    public Transform hedef;

    void Start()
    {
        /*speed = 1;
        trailefekt = GetComponentInChildren<TrailRenderer>();*/
        line = GetComponent<LineRenderer>();
    }

    void Update()
    {
        line.SetPosition(0, transform.position);
        line.SetPosition(1, hedef.position);


        /*if (speed < 5)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            trailefekt.time = 3f;
        }
        else
        {
            transform.Translate(Vector3.right * speed * 2 * Time.deltaTime);
            trailefekt.time = .1f;
            trailefekt.startColor = new Color(.93f, 1f, .47f);
            trailefekt.endColor = new Color(.43f, 1f, .75f);
            //trailefekt.startColor = Color.white;
            //trailefekt.endColor = Color.yellow;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.up * 10f * 2 * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.down * 10f * 2 * Time.deltaTime);
        }
        */
    }
}
