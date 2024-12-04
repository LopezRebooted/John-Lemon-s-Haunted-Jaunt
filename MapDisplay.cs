using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplay : MonoBehaviour
{
    public CanvasGroup mapCanvasGroup;

    // Start is called before the first frame update
    void Start()
    {
            mapCanvasGroup.alpha = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            mapCanvasGroup.alpha = 0;

    }
}
