using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBox : MonoBehaviour {


void OnTriggerEnter2D(Collider2D other)
{
    //    int number = System.Enum.GetValues(typeof(Player.Weapons)).Length;
    int number = System.Enum.GetValues(typeof(Player.Plantings)).Length;
         int random = Random.Range(0,number);
    // other.GetComponent<Player>().currentWeapon = (Player.Weapons)random;
    other.GetComponent<Player>().currentPlanting = (Player.Plantings)random;
    //     print(random);
    Destroy(gameObject);

}
}
