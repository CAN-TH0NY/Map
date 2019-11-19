using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    private Vector2 SmoothV;
    private Vector2 mouseLook;

    public float smoothing = 2.0f;
    public float sensibility = 5.0f;
    GameObject character;
    

    // Start is called before the first frame update
    void Start()
    {
        character = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        md = Vector2.Scale(md, new Vector2(sensibility * smoothing, sensibility * smoothing));
        SmoothV.x = Mathf.Lerp(SmoothV.x, md.x, 1f / smoothing);
        SmoothV.y = Mathf.Lerp(SmoothV.y, md.y, 1f / smoothing);
        mouseLook += SmoothV;

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);

        mouseLook.y = Mathf.Clamp(mouseLook.y, -90f, 90f);
        mouseLook += SmoothV;



    }
}
