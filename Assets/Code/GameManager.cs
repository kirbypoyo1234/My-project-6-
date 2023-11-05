using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float attackSpeedMulitiplier = 1f;
  public static void increasedMultiplier(float amount)
    {
        attackSpeedMulitiplier *= amount;
    }
}
