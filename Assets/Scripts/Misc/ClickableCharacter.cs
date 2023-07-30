using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;
using UnityEngine.Events;

public class ClickableCharacter : MonoBehaviour
{
    [SerializeField] protected UnityEvent onClick;

    private void OnMouseDown()
    {
        onClick.Invoke();
    }
}
