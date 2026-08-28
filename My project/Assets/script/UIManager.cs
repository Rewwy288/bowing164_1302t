using TMPro;
using UnityEngine;

public class UImanager : MonoBehaviour
{

    [SerializeField]
    private TMP_Text notiText;
    [SerializeField]
    private GameObject restartButton;

    [SerializeField]
    private GameObject Ball ;//it red

    public static UImanager instance;

    private void Awake()
    {
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowNotitext(string message)
    {
        notiText.text = message;
    }

}