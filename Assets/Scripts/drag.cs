﻿using UnityEngine;

public class drag : MonoBehaviour
{
    private Vector3 dist;
    private float posX;
    private float posY;

    void OnMouseDown()
    {
        Debug.Log("OnMouseDown");

        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;
    }

    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(1))
    //    {
    //        Debug.Log("OnMouseDown");

    //        dist = Camera.main.WorldToScreenPoint(transform.position);
    //        posX = Input.mousePosition.x - dist.x;
    //        posY = Input.mousePosition.y - dist.y;
    //    }
    //}

    void OnMouseDrag()
    {
        Vector3 curPos = new Vector3(Input.mousePosition.x - posX, Input.mousePosition.y - posY, dist.z);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        transform.position = worldPos;
    }
}
