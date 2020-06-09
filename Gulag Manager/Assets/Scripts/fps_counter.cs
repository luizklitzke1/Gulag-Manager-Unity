using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;
 
public class fps_counter : MonoBehaviour
{
	float deltaTime = 0.0f;

    public TextMeshProUGUI fps_display;

 
	void Update()
	{
		deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;

	}
 
	void OnGUI()
	{

		float msec = deltaTime * 1000.0f;
		float fps = 1.0f / deltaTime;
		string text = string.Format("FPS: {1:0.} MS: {0:0.0}", msec, fps);

        fps_display.SetText(text);

	}
}