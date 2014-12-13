using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateHud : MonoBehaviour {

    private bool hasHud;

    private Text heightText;
    private Text cactusText;
    private Text endOfGameText;
    private Player player;

	// Use this for initialization
	void Start () {
        hasHud = GameObject.Find("/HUD") != null;

        if (hasHud)
        {
            this.heightText = GameObject.Find("/HUD/Height").GetComponent<Text>();
            this.cactusText = GameObject.Find("/HUD/CactusCounterText").GetComponent<Text>();
            this.endOfGameText = GameObject.Find("/HUD/EndOfGameText").GetComponent<Text>();
            this.player = GameObject.Find("/Player").GetComponent<Player>();
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
        this.cactusText.text = string.Format("{0}/{1} cactii saved", player.cactiiCollected, player.cactiiRequired);

        if (player.cactiiCollected == player.cactiiRequired)
        {
            player.GetComponent<CharacterMotor>().canControl = false;
            this.endOfGameText.text = "You have won!";
        }
	}
}
