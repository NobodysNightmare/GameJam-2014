using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateHud : MonoBehaviour {

    private bool hasHud;

    private Text heightText;
    private Text cactusText;
    private PlayerVariables playerVariables;

	// Use this for initialization
	void Start () {
        hasHud = GameObject.Find("/HUD") != null;

        if (hasHud)
        {
            this.heightText = GameObject.Find("/HUD/Height").GetComponent<Text>();
            this.cactusText = GameObject.Find("/HUD/CactusCounterText").GetComponent<Text>();
            this.playerVariables = GameObject.Find("/Player").GetComponent<PlayerVariables>();

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
        this.cactusText.text = string.Format("{0} of {1} cactii saved", playerVariables.cactii, playerVariables.cactii);
	}
}
