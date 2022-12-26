using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public static Light instance;

    [SerializeField] private Sprite[] sprite;
    [SerializeField] private SpriteRenderer spriteRenderer;


    private void Start()
    {
        instance = this;
        StartCoroutine(Change());
    }

    private IEnumerator Change()
    {
        yield return new WaitForSeconds(Random.Range(0, 0.5f));

        spriteRenderer.sprite = sprite[Random.Range(0, sprite.Length)];
        StartCoroutine(Change());
    }

}
