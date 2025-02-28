using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public Canvas targetCanvas;

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        targetCanvas.gameObject.SetActive(false);
    }
}
