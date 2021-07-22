using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressSpaceToReset : MonoBehaviour
{
    public TextMeshProUGUI TextMeshProUGUI;

    GameObject armL, armR;
    Vector3 leftArmFirstPos, rightArmFirstPos;

    // Start is called before the first frame update
    void Start()
    {
        //set up the objects and their positions
        armL = GameObject.FindGameObjectWithTag("Arm_Left");
        leftArmFirstPos = armL.transform.position;
        armR = GameObject.FindGameObjectWithTag("Arm_Right");
        rightArmFirstPos = armR.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //press space to reset
        if (Input.GetKeyDown("space"))
        {
            armL.transform.position = leftArmFirstPos;
            armR.transform.position = rightArmFirstPos;
        }

        //also changes the status text
        if (Vector3.Distance(armL.transform.position, leftArmFirstPos) > 0.02)
        {
            TextMeshProUGUI.text = "DETACHED";
        }
        else if(Vector3.Distance(armR.transform.position, rightArmFirstPos) > 0.02)
        {
            TextMeshProUGUI.text = "DETACHED";
        }
        else
        {
            TextMeshProUGUI.text = "ATTACHED";
        }
    }
}
