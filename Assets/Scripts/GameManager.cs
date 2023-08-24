using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 敵関係のゲームオブジェクトをアタッチする配列
    public GameObject[] Enemys;
    // プレイヤー関係のゲームオブジェクトをアタッチする配列
    public GameObject[] Players;

    /// <summary>
    /// Player側の攻撃を行う際に呼び出すメソッド
    /// </summary>
    public void PlayerAttack()
    {
        var hit = Enemys[Random.Range(0, 2)].GetComponent<IDamagable>();

        hit.AddDamage();
    }

    /// <summary>
    /// Enemy側の攻撃を行う際に呼び出すメソッド
    /// </summary>
    public void EnemyAttack()
    {
        var hit = Players[Random.Range(0, 2)].GetComponent<IDamagable>();

        hit.AddDamage();
    }

    /// <summary>
    /// プレイヤーを回復させる際に呼び出すメソッド
    /// </summary>
    public void PlayerHeal()
    {
        foreach(var element in Players){
            var r = element.GetComponent<IHearable>();
            r.AddHp(10);
        }
    }
}
