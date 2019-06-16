using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFollow : MonoBehaviour
{
    public RectTransform UGUICavas;
    public Camera mainCamera;

    void Update()
    {
        Vector2 vector2 = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector3 mousePos;
        RectTransformUtility.ScreenPointToWorldPointInRectangle(UGUICavas, vector2, mainCamera, out mousePos);
        float z;
        if (mousePos.x > transform.position.x)
        {
            z = -Vector3.Angle(Vector3.up, mousePos - transform.position);
        }
        else
        {
            z = Vector3.Angle(Vector3.up, mousePos - transform.position);
        }
        transform.localRotation = Quaternion.Euler(0,0,z);
    }
}