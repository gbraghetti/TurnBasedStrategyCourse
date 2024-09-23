using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActionButtonUI : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI textMeshPro;
    [SerializeField] private Button button;
    [SerializeField] private GameObject seletedGameObject;

    private BaseAction baseAction;

    public void SetBaseAction(BaseAction baseAction) {
        this.baseAction = baseAction;
        textMeshPro.text = baseAction.GetActionName().ToUpper();

        button.onClick.AddListener(() => {
            UnitActionSystem.Instance.SetSelectedAction(baseAction);
        });
    }

    public void UpdateSelectedVisual() {
        BaseAction selectedBaseAction = UnitActionSystem.Instance.GetSelectedAction();
        seletedGameObject.SetActive(selectedBaseAction == baseAction);
    }
}
