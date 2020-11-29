using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TypeWritterEffect : MonoBehaviour
{

    public TextMeshProUGUI text;

    public float delay = 0.1f;

    public string full_text;

    public string current_text = "";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowText());
    }

    // Update is called once per frame
    public void Reset()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText(){

        for (int i = 0; i < full_text.Length+1; i ++){
            current_text = full_text.Substring(0,i);
            text.SetText(current_text);
            yield return new WaitForSeconds(delay);
        }

    }
}
