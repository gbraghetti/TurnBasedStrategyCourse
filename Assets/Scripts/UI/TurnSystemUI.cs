using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TurnSystemUI : MonoBehaviour {

    [SerializeField] private Button endTurnBtn;
    [SerializeField] private TextMeshProUGUI turnNumberText;
    [SerializeField] private GameObject enemeyTurnVisualGameObject;

    private void Start() {
        endTurnBtn.onClick.AddListener(() => {
            TurnSystem.Instance.NextTurn();
        });

        TurnSystem.Instance.OnTurnChanged += TurnSystem_OnTurnChanged;

        UpdateTurnText();
        UpdateEnemyTurnvisual();
        UpdateEndTurnButtonVisibility();
    }

    private void TurnSystem_OnTurnChanged(object sender, EventArgs e) {
        UpdateTurnText();
        UpdateEnemyTurnvisual();
        UpdateEndTurnButtonVisibility();
    }

    private void UpdateTurnText() {
        int turnNumber = TurnSystem.Instance.GetTurnNumber();
        turnNumberText.text = $"TURN {turnNumber}";
    }

    private void UpdateEnemyTurnvisual() {
        enemeyTurnVisualGameObject.SetActive(!TurnSystem.Instance.IsPlayerTurn());
    }

    private void UpdateEndTurnButtonVisibility() {
        endTurnBtn.gameObject.SetActive(TurnSystem.Instance.IsPlayerTurn());
    }


}
