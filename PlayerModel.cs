using UnityEngine;

public class PlayerModel
{
  string name;
  int hp;
  int at;

  public PlayerModel()
  {
    name = "hero";
  }

  public void SayName()
  {
    Debug.Log(name);
  }
}