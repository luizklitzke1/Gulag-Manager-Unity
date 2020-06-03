using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resize_img : MonoBehaviour
{
    public Image Image;
    public Vector3 size;
    private Vector3 initial_scale;

    void Start()
    {
        initial_scale = Image.rectTransform.localScale;
    }

    public void resize()
    {
        Image.rectTransform.localScale = size;
    }

    public void original_size()
    {
        Image.rectTransform.localScale = initial_scale;
    }

}
