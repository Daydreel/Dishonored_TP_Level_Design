using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerState : MonoBehaviour
{

    public Image powerImage;

    public Sprite spriteBlink;
    public Sprite spritePossession;

    public enum Powers
    {
        Blink,
        Possession,
    }

    public Powers currentPower;

    // Start is called before the first frame update
    void Start()
    {
        currentPower = Powers.Blink;
        powerImage.sprite = spriteBlink;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Current power" + currentPower);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentPower = Powers.Blink;
            powerImage.sprite = spriteBlink;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentPower = Powers.Possession;
            powerImage.sprite = spritePossession;
        }
    }
}
