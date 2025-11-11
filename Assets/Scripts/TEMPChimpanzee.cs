using UnityEngine;

public class Chimpanzee : Animal
{
    public override void MakeSound()
    {
        MonoBehaviour.print("The chimpanzee says: I bit your face off");
    }
}