using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Color startcolor;
    Renderer objRenderer;

    private void Start()
    {
        objRenderer = GetComponent<Renderer>();
    }

    //highlight the selected arm
    void OnMouseEnter()
    {
        startcolor = objRenderer.material.color;
        objRenderer.material.color = Color.red;
    }
    //reset once the mouse is not on it
    void OnMouseExit()
    {
        objRenderer.material.color = startcolor;
    }
}
