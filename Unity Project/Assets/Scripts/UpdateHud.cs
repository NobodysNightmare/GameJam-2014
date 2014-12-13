using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateHud : MonoBehaviour {

    private bool hasHud;

    private Text heightText;

	// Use this for initialization
	void Start () {
        hasHud = GameObject.Find("/HUD") != null;

        if (hasHud)
        {
            this.heightText = GameObject.Find("/HUD/Height").GetComponent<Text>();

            if (this.heightText == null)
            {
                Debug.LogError("Could not find height text element", this);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (!hasHud)
        {
            return;
        }

        var height = Mathf.Floor(this.transform.position.y * 10f) / 10f;
        this.heightText.text = string.Format("Height: {0}", height);
	}
}
