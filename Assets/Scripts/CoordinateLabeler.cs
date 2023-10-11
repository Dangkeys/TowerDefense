using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
[ExecuteAlways]
public class CoordinateLabeler : MonoBehaviour
{
    TextMeshPro label;
    Vector2Int coordinates = new Vector2Int();
    private void Awake() {
        label = GetComponent<TextMeshPro>();
        DisplayCoordinates();
    }

    private void UpdateObjectName()
    {
        transform.parent.name = coordinates.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayCoordinates();
        UpdateObjectName();
    }

    private void DisplayCoordinates()
    {
        if (!Application.isPlaying)
        {
            coordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
            coordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);
            label.text = coordinates.x + "," + coordinates.y;
        }
    }
}