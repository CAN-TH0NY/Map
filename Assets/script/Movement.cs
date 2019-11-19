using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private float ticker;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
            ticker = 1f;
         }
        if (Input.GetKeyDown("escape") && (ticker == 1f))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        float VerticalAxis = (Input.GetAxis("Vertical") * speed);
        float HorizontalAxis = (Input.GetAxis("Horizontal") * speed);
        VerticalAxis *= Time.deltaTime;
        HorizontalAxis *= Time.deltaTime;

        transform.Translate(HorizontalAxis, 0, VerticalAxis);

    }
}
