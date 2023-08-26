using UnityEngine;

public class PlayerModel
{
  string name;
  int hp;
  int at;

  // プロパティ
  public int Hp
  {
    get { return hp; }
    set { hp = value; }
  }

  public PlayerModel()
  {
    name = "hero";
  }

  public void SayName()
  {
    Debug.Log(name);
  }
}