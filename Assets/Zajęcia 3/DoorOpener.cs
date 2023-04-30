using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public bool beenTouched = false;
    public Transform component;

    private void Update()
    {
        // Instrukcja warunkowa if sprawdza czy warunek w nawiasie jest spelniony - warosc typu bool jest rowna true
        // Jezeli tak, to wykonuje się operacja w nawiasie klamrowym lub 1 linijka kodu ponizej
        // po tym mozna dodac slowo kluczowe else ktore wykonuje sie jezeli warunek nie byl spelniony
        if (beenTouched)
            component.Translate(Vector3.down * Time.deltaTime * 2);
        else
        {
            Debug.Log("Drzwi zostaja zamkniete");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        beenTouched = true;
    }
}
