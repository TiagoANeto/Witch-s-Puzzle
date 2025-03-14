using UnityEngine;

public class Player : MonoBehaviour, IMovement
{
    public CharacterController cc { get; set;}
    public float movSpeed { get; set;}

    private void Movement(Vector2 movInput)
    {
        
    }
}
