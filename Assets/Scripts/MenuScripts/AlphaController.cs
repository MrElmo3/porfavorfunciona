using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaController : MonoBehaviour
{
    public float alpha;

    private Color actualColor;

    private void Start() {
        for(int i =0; i< transform.childCount; i++){
            actualColor = transform.GetChild(i).GetComponent<SpriteRenderer>().color;
            actualColor.a = alpha;
            transform.GetChild(i).GetComponent<SpriteRenderer>().color = actualColor;
        }
    }
}
