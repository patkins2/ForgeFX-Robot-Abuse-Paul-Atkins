using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToDrag : MonoBehaviour
{
    private Vector3 mouseOffset;
    private float mouseZ;

    void OnMouseDown()
    {
        mouseZ = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mouseOffset = gameObject.transform.position - GetMouseWorldPoint();
    }

    void OnMouseDrag()
    {
        //locking the z
        transform.position = new Vector3(GetMouseWorldPoint().x + mouseOffset.x, GetMouseWorldPoint().y + mouseOffset.y, transform.position.z);
    }

    private Vector3 GetMouseWorldPoint()
    {
        //Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;

        //z coordinate of game object on screen
        mousePoint.z = mouseZ;

        //Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    
}
