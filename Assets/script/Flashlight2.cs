using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flashlight2 : MonoBehaviour
{
    public GameObject CharacterFlashlight;
    public GameObject CharacterLight;
    private float ButtonActivable;
    private float FlashlightOpened;
    private float FlashlightObtained;
    public GameObject FlashlightObj;
    public GameObject Character;
    public Text PickupText;
    private float TriggerDetection;
    private float LookDetection;
    // Start is called before the first frame update
    void Start()
    {
        Character = GameObject.Find("BatonCharacter");
        FlashlightObtained = 1f;
        CharacterLight = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
       

        if (FlashlightObtained == 1f && Input.GetKeyDown(KeyCode.F))
        {
            CharacterLight.gameObject.SetActive(true);
            FlashlightOpened = 1f;

        }

        if (FlashlightOpened == 1f && Input.GetKeyDown(KeyCode.F))
        {
            CharacterLight.gameObject.SetActive(false);
            FlashlightOpened = 0f;


        }

    }
}
