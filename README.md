# 🎡 Roulette Game (룰렛 회전 게임)

**Roulette Game**은 유니티 엔진(2022.3.62f3)을 활용하여 제작한 2D 게임입니다.
마우스 클릭을 통해 룰렛을 회전시키고, 마찰력을 구현하여 자연스럽게 멈추는 로직을 학습하기 위해 제작되었습니다.

---

## 🛠 개발 환경 (Environment)
*   **Unity Version:** 2022.3.62f3
*   **Language:** C#
*   **Platform:** PC (Windows)

---

## 🎮 게임 조작법 (Controls)
마우스 클릭 한 번으로 간편하게 룰렛을 조작할 수 있습니다.

| 입력 (Input) | 동작 (Action) |
| :--- | :--- |
| **Mouse Left Click** | 룰렛 회전 시작 (가속) |

---

## 💡 핵심 로직 설명 (Core Logic)

`RouletteController.cs` 스크립트에서 구현된 주요 로직은 다음과 같습니다.

### 1. 회전 제어 (Rotation)
`Update` 함수 내에서 매 프레임마다 오브젝트의 Z축을 회전시킵니다.
*   **코드**: `transform.Rotate(0, 0, this.rotSpeed);`
*   **설명**: `rotSpeed` 변수 값에 따라 회전 속도가 결정됩니다.

### 2. 마찰 및 감쇠 (Damping)
실제 물리 법칙처럼 속도가 서서히 줄어들도록 감쇠 계수를 사용했습니다.
*   **코드**: `this.rotSpeed *= 0.96f;`
*   **설명**: 매 프레임마다 현재 속도의 96%만 유지하게 하여, 결과적으로 자연스럽게 감속하며 정지하게 됩니다.

### 3. 입력 이벤트 (Input Event)
사용자가 화면을 클릭하는 순간 최대 속도를 부여합니다.
*   **코드**: `if (Input.GetMouseButton(0)) { this.rotSpeed = 10; }`
*   **설명**: 클릭 시 `rotSpeed`를 10으로 초기화하여 즉각적인 가속감을 제공합니다.

---

## 💻 스크립트 전문 (Script)

```csharp
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 회전 속도 변수

    void Update()
    {
        // 클릭 시 회전 속도 부여
        if (Input.GetMouseButton(0))
        {
            this.rotSpeed = 10;
        }

        // 룰렛 회전 실행
        transform.Rotate(0, 0, this.rotSpeed);

        // 속도 감소
        this.rotSpeed *= 0.96f;
    }
}
