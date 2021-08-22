using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class MostrarControles : MonoBehaviour
{
    [SerializeField]
    private GameObject _controles;
    private void OnTriggerExit2D(Collider2D other)
    {
        _controles.gameObject.SetActive(false);
    }
}
