using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Material CollectedMaterial;
    public PlayerState playerState;
    public LevelState levelState;

    public Transform collectedPooolTransform;
    public List<GameObject> collidedList;
    public enum PlayerState
    {
        Stop,
        Move
    }
    public enum LevelState
    {
        NotFinished,
        Finished
    }
}
