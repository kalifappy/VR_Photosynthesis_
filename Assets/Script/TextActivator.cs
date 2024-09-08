using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextActivator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshPro arrow;
    [SerializeField] TextMeshPro steam;
    [SerializeField] TextMeshPro arrow_1;
    [SerializeField] TextMeshPro leaf;
    [SerializeField] GameObject realLeaf;
    [SerializeField] GameObject fake_leaf;
    void Start()
    {
        arrow.gameObject.SetActive(false);
        steam.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stem()
    {
        arrow.gameObject.SetActive(true);
        steam.gameObject.SetActive(true);
    }
    public void Leaf()
    {
        arrow_1.gameObject.SetActive(true);
        leaf.gameObject.SetActive(true);
    }

    public void LeafOffGame()
    {
        realLeaf.gameObject.SetActive(false);
        fake_leaf.SetActive(true);
    }

}
