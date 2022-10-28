using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ColorButton : MonoBehaviour, ISelectHandler, IDeselectHandler {

    [SerializeField] private Sprite overlayUnpressed, overlayPressed;
    [SerializeField] private Image shirt, overalls, overlay;
    public string ColorString;
    public PlayerColorSet palette;
    public GameObject PaletteNamer;

    public void Instantiate(PlayerData player) {
        if (palette == null) {
            shirt.enabled = false;
            overalls.enabled = false;
            return;
        }

        PlayerColors col = palette.GetPlayerColors(player);
        shirt.color = col.hatColor;
        overalls.color = col.overallsColor;
        ColorString = col.ColorName;
        overlay.enabled = false;
    }

    public void OnSelect(BaseEventData eventData) {
        overlay.enabled = true;
        overlay.sprite = overlayUnpressed;
        PaletteNamer.GetComponent<TMP_Text>().text = ColorString;
    }

    public void OnDeselect(BaseEventData eventData) {
        overlay.enabled = false;
        overlay.sprite = overlayUnpressed;
    }

    public void OnPress() {
        overlay.sprite = overlayPressed;
    }
}