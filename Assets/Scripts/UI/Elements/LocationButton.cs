using UnityEngine;
using Naninovel;
using UnityEngine.UI;

public class LocationButton : MonoBehaviour
{
    [SerializeField] private string locationAlias;
    [SerializeField] private GameObject mark;
    private Button button;
    private PlayScript playScript;

    public string LocationAlias => locationAlias;

    private void Awake()
    {
        button = GetComponent<Button>();
        playScript = GetComponent<PlayScript>();

        button.onClick.AddListener(() => playScript.Play(locationAlias));
    }

    public void SetMarked(bool value) 
    {
        mark.SetActive(value);
    }

    public void SetAwaliable(bool value) 
    {
        button.interactable = value;
    }
}
