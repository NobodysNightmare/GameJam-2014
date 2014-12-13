using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateHud : MonoBehaviour {

    public Canvas Hud;

    private bool HasHud
    {
        get { return Hud != null; }
    }

    private Text heightText;

	// Use this for initialization
	void Start () {
        if (HasHud)
        {
            this.heightText = Hud.GetComponentInChildren<Text>();

            if (this.heightText == null)
            {
                Debug.LogError("Could not find height text element", this);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (!HasHud)
        {
            return;
        }

        var height = Mathf.Floor(this.transform.position.y * 10f) / 10f;
        this.heightText.text = string.Format("Height: {0}", height);
	}
}
