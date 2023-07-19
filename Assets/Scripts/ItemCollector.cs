using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int counter = 0;

    [SerializeField]
    private TextMeshProUGUI pineappleTxt;

    [SerializeField]
    private AudioSource collectionSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pineapple"))
        {
            collectionSound.Play();
            Destroy(collision.gameObject);
            counter++;
            pineappleTxt.text = "Pineapples:" + counter;
        }
    }
}
