using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateUI : MonoBehaviour {


	void CreateFullScreenRawImage(RectTransform parentRectTransform)
	{
		Debug.Log (parentRectTransform.rect.size.x);
		Debug.Log (parentRectTransform.rect.size.y);

		GameObject o_rawImage = new GameObject ("rawImage");
		o_rawImage.transform.parent = parentRectTransform;
		RawImage rawImage = o_rawImage.AddComponent<RawImage> ();

		rawImage.rectTransform.SetInsetAndSizeFromParentEdge (RectTransform.Edge.Left, 0, 0);
		rawImage.rectTransform.SetInsetAndSizeFromParentEdge (RectTransform.Edge.Right, 0, 0);
		rawImage.rectTransform.SetInsetAndSizeFromParentEdge (RectTransform.Edge.Top, 0, 0);
		rawImage.rectTransform.SetInsetAndSizeFromParentEdge (RectTransform.Edge.Bottom, 0, 0);


		rawImage.rectTransform.anchorMin = new Vector2 (0, 0);
		rawImage.rectTransform.anchorMax = new Vector2 (1, 1);
	}

	// Use this for initialization
	void Start () {

		GameObject o_canvas = new GameObject ("Canvas");
		Canvas canvas = o_canvas.AddComponent<Canvas> ();
		o_canvas.AddComponent<CanvasScaler> ();
		canvas.renderMode = RenderMode.ScreenSpaceOverlay;

		CreateFullScreenRawImage (o_canvas.GetComponent<RectTransform>());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
