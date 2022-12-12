using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using Photon.Pun;
using Photon.Realtime;
using NSMB.Utils;

public class ScoreboardEntry : MonoBehaviour {

    [SerializeField] private TMP_Text nameText, valuesText;
    [SerializeField] private Image background;

    public PlayerController target;

    private int playerId, currentLives, currentStars;
    private bool rainbowEnabled;

    public void Start() {
        if (!target) {
            enabled = false;
            return;
        }

        playerId = target.playerId;
        nameText.text = target.photonView.Owner.GetUniqueNickname();

        Color c = target.AnimationController.GlowColor;
        background.color = new(c.r, c.g, c.b, 0.5f);

        rainbowEnabled = target.photonView.Owner.HasRainbowName();
    }

    public void Update() {
        CheckForTextUpdate();

        if (rainbowEnabled)
            nameText.color = Utils.GetRainbowColor();
        if (target.photonView.Owner.HasPoopieName())
        {
            if (target.photonView.Owner.IsLocal || PhotonNetwork.LocalPlayer.HasPoopieName())
            {
                nameText.color = new Color(1f, 0.82353f, 0.2f);
            }
            else
            {
                nameText.color = new Color(0.490196f, 0.2862745f, 0.14117647f);
            }
        }
        if (target.photonView.Owner.HasRainbowName() && target.photonView.Owner.UserId == "a3375a1a-a161-4620-b952-6e013040d1e1")
        {
            nameText.color = new Color(0.490196f, 0.2862745f, 0.14117647f);
        }
    }

    public void CheckForTextUpdate() {
        if (!target) {
            // our target lost all lives (or dc'd)
            background.color = new(0.4f, 0.4f, 0.4f, 0.5f);
            return;
        }
        if (target.lives == currentLives && target.stars == currentStars)
            // No changes.
            return;

        currentLives = target.lives;
        currentStars = target.stars;
        UpdateText();
        ScoreboardUpdater.instance.Reposition();
    }

    public void UpdateText() {
        string txt = "";
        if (currentLives >= 0)
            txt += target.character.uistring + Utils.GetSymbolString(currentLives.ToString());
        txt += Utils.GetSymbolString($"S{currentStars}");

        valuesText.text = txt;
    }

    public class EntryComparer : IComparer<ScoreboardEntry> {
        public int Compare(ScoreboardEntry x, ScoreboardEntry y) {
            if (x.target == null ^ y.target == null)
                return x.target == null ? 1 : -1;

            if (x.currentStars == y.currentStars || x.currentLives == 0 || y.currentLives == 0) {
                if (Mathf.Max(0, x.currentLives) == Mathf.Max(0, y.currentLives))
                    return x.playerId - y.playerId;

                return y.currentLives - x.currentLives;
            }

            return y.currentStars - x.currentStars;
        }
    }
}