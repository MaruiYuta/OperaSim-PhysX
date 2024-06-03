using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // 回転速度を指定します（度/秒）
    public float rotationSpeed = 90.0f;  // 例えば90度/秒

    // 回転した角度を追跡するための変数
    private float totalRotation = 0.0f;

    void Update()
    {
        // 今フレームでの回転量を計算
        float rotationThisFrame = rotationSpeed * Time.deltaTime;

        // 合計回転量を更新
        totalRotation += rotationThisFrame;

        // 回転量が360度を超えないようにする
        if (totalRotation >= 360.0f)
        {
            rotationThisFrame -= (totalRotation - 360.0f);
            totalRotation = 360.0f;  // 正確に360度に設定
        }

        // オブジェクトを回転させる
        transform.Rotate(Vector3.right * rotationThisFrame);

        // 合計回転量が360度に達したら回転を停止
        if (totalRotation >= 360.0f)
        {
            enabled = false;  // このスクリプトを無効化して回転を停止
        }
    }
}

