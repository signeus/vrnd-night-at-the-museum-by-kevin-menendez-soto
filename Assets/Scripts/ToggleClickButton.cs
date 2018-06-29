using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleClickButton : MonoBehaviour {
    public GameObject canvas;
	
    public void enableDisableCanvas()
    {
        canvas.SetActive(!canvas.activeSelf);
    }

}
