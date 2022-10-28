using NSMB.Utils;
using UnityEngine;
using UnityEngine.UI;

public class MarioLoader : MonoBehaviour {

    public int scale = 2, previousScale = 2;
    public float scaleTimer, blinkSpeed = 0.5f;
    private Image image;
    public PlayerData data;
    public void Start() {
        image = GetComponent<Image>();
        data = Utils.GetCharacterData();
    }

    public void Update() {
        int scaleDisplay = scale;

        if ((scaleTimer += Time.deltaTime) < 0.5f) {
            if (scaleTimer % blinkSpeed < blinkSpeed / 2f)
                scaleDisplay = previousScale;
        } else {
            previousScale = scale;
        }

        if (scaleDisplay == 0) {
            transform.localScale = Vector3.one * 0.5f;
            image.sprite = data.loadingSmallSprite;
        } else if (scaleDisplay == 1) {
            transform.localScale = Vector3.one;
            image.sprite = data.loadingSmallSprite;
        } else if (scaleDisplay == 2) {
            transform.localScale = Vector3.one;
            image.sprite = data.loadingBigSprite;
        } else if (scaleDisplay == 3) {
            transform.localScale = Vector3.one * 2;
            image.sprite = data.loadingBigSprite;
        } else if (scaleDisplay == 4) {
            transform.localScale = Vector3.one * 4;
            image.sprite = data.loadingBigSprite;
        } else if (scaleDisplay == 5) {
            transform.localScale = Vector3.one * 8;
            image.sprite = data.loadingBigSprite;
        } else {
            transform.localScale = Vector3.one;
            image.sprite = data.loadingBigSprite;
        }
    }
}
