using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Jogador : MonoBehaviour
{
    [SerializeField]
    private GameObject _podeInteragirTxt;
    [SerializeField]
    private List<string> _itemsDeInventario = new List<string>();

    public bool EstaInteragindo { get; set; }

    void Update()
    {
        if (Input.GetButtonDown("Interage"))
        {
            EstaInteragindo = true;
            _podeInteragirTxt.gameObject.SetActive(false);
        }
        else
        {
            EstaInteragindo = false;
        }
    }

    public void AdicionaItem(string nomeItem)
    {
        _itemsDeInventario.Add(nomeItem);
    }

    public bool TemItem(string nomeItem)
    {
        return _itemsDeInventario.Contains(nomeItem);
    }

}