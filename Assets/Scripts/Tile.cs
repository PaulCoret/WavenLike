using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Material baseColor, offsetColor;
    [SerializeField] private MeshRenderer _renderer;
    [SerializeField] private GameObject highlight;

    public void Init(bool isOffset)
    {
        _renderer.material = isOffset ? offsetColor : baseColor;
    }

    private void OnMouseEnter()
    {
        highlight.SetActive(true);
    }
    private void OnMouseExit()
    {
        highlight.SetActive(false);
    }

}
