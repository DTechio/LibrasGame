using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class Interagir : MonoBehaviour
{
    [SerializeField]
    private Jogador _jogador;

    [SerializeField]
    private bool _deveChecar;

    [SerializeField]
    private string _nomeDoItem;

    [SerializeField]
    private UnityEvent _botaoApertado;

    [SerializeField]
    private GameObject _caixaDialogo;

    [SerializeField]
    private GameObject _podeInteragirTxt;

    private bool _podeExecutar;

    void Update()
    {
        if (_podeExecutar && _jogador.EstaInteragindo == true)
        {
            if (_deveChecar)
            {
                if (_jogador.TemItem(_nomeDoItem))
                    _botaoApertado.Invoke();
            }
            else
            {
                _botaoApertado.Invoke();
            }


        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _podeExecutar = true;
        _podeInteragirTxt.gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _podeExecutar = false;
        _caixaDialogo.gameObject.SetActive(false);
        _podeInteragirTxt.gameObject.SetActive(false);
    }
}