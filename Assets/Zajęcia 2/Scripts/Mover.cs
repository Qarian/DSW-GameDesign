using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Przesuwa obiekt 
public class Mover : MonoBehaviour
{
    // Domyślnie skrypt będzie przesuwał obiekt, do którego jest przypięty, o jedną jednostkę na sekundę w osi X (w prawo)
    // Ale zmienna jest publiczna więc da się ją edytować w inspektorze
    public Vector3 speed = new Vector3(1, 0, 0);

    // Update wywołuje się co klatkę więc możemy go użyć do płynnego przesuwania bloku
    private void Update()
    {
        // Przesuwanie obiektu można zrobić przez wzięcie obecnej pozycji, dodanie do niej wartości o ile chcemy przesunąć i ustawienie pozycji na tą sumę
        // Nie wiemy jednak jak często będzie wywoływał się Update, dlatego musimy przemnożyć wartośc przesunięcie o czas klatki (Time.deltaTime)
        GetComponent<Transform>().position = GetComponent<Transform>().position + (speed * Time.deltaTime);

        // Żeby nie odwoływać się 2 razy do pozycji można powyższą linijkę uprościć
        GetComponent<Transform>().position += speed * Time.deltaTime;

        // Klasa Transform pozwala nam też zrobić to samo poprzez funkcję
        GetComponent<Transform>().Translate(speed * Time.deltaTime);

        // Funkcja ta może przyjąc kilka rodzaji argumentów dzięki tzw Przeciązaniu funkcji (function overload)
        // Transform.Translate() ma 6 przeciążeń i jedno z nich pozwala wpisać każdą wartośc osobno
        // Dobrze skonfigurowane IDE pokaże wszystkie przeciążenia, albo można sprawdzic w dokumentacji (najłatwiej przez google)
        GetComponent<Transform>().Translate(speed.x * Time.deltaTime, speed.y * Time.deltaTime, speed.z * Time.deltaTime);
    }
}
