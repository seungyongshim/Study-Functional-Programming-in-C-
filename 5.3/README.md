## 5.3 부작용이 없는 프로그래밍
- 가변 상태가 없이 작동하는 소프트웨어를 작성하는 것은 어렵다.
- 순수 함수형 프로그램은 값을 변경하는 대신 새로운 값을 만든다.
- 항상 프로그램은 새로운 세상을 창조하는 것이다. (상태가 아니다.)

### 미로 게임 예제
- 미로와 플레이어가 있고 플레이어를 미로에서 이동시키는 것은 **상태 변경** 방식이다.
- 불변으로 모델링 하는 방법을 알아본다.

### 함수적 사고 (미로 게임)
- 미로는 불변이다.
- 플레이어는 이동하며 이때 새로운 위치를 계산하기 필요한 데이터가 있다.
   - 이동할 방향
   - 어디서 부터 오는지 이전 위치
   - 원하는 방향으로 이동 가능한지 여부
- 가변 변수 없는 이동 로직 예시
```cpp
position_t next_position(direction_t direction, const position_t& previous_position, const maze_t& maze)
{
    const position_t desired_position{previous_position, direction};

    return maze.is_wall(desired_postion) ? previous_position : desired_position;
}
```
- 플레이어를 보여줄 방법은 무엇인가?
- 프레젠테이션 계층에서 미로와 미로 내 플레이어를 그린다.
- 미로는 변하지 않기 때문에 플레이어를 표현하는 것에만 신경이 쓰인다.
```cpp
void draw_player (const position_t& position, direction_t direction)
``` 