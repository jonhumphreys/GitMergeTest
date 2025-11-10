using System.Collections.Generic;
using UnityEngine;


public class TestMain : MonoBehaviour
{
    public void Start()
    {
        List<Animal> animals = new List<Animal>();
        
        //animals.Add(new Cassowary());
        //animals.Add(new BulletAnt());
        //animals.Add(new BlueRingedOctopus());
        //animals.Add(new Chimpanzee());
        
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }
}
