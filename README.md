﻿# __게임 프로그래밍(기말) 기획서__

### __원본 게임__: A Simple 2D Platformer!
> 원본게임에 기능을 추가 할 예정.<br/>
> 원본 소스코드: https://www.youtube.com/watch?v=12d4WtmrEZs

### __프로젝트 마감일__: 2019/12/18

### __사용 엔진__: 유니티 + C#

### __추가 및 개선, 해야할 기능__
  * 튜토리얼 스테이지 추가
  * pause키 볼륨 바인딩
  * SFX 구하기 - 일단 구현해놓고 소스가 없음
  * 스테이지 다 만들면 빌드해야함

### __추가 및 개선, 변경된 기능__
  * Tilemap 시스템으로 변경
    * Rule Tile 적용
  * Platform 이미지 변경
    * Grass Land 플랫폼 추가
      * Hover tile 추가
    * Brick Land 플랫폼 추가
    * 풀 장식 추가
    * 백그라운드 플랫폼 추가
  * 배경화면 추가
    * 플레이어 이동기반 배경화면 수정
  * 카메라가 플레이어를 따르도록 변경
    * Smooth Camera follow 추가
  * 장애물 추가
    * 밟을시 떨어지는 플랫폼 추가
    * 밀기 가능한 박스 추가
    * 가시추가
  * 플레이어 이미지 변경
    * Idle 애니메이션 추가
    * Running 애니메이션 추가
    * Jumping  애니메이션 추가
    * Crouching  애니메이션 추가
    * Hurt 애니메이션 추가
  * 플레이어 컨트롤 로직 개선
    * 비선형적인 플레이어 이동로직으로 개선
    * 비선형적인 플레이어 멈춤로직 추가
    * 떨어지는 플랫폼상 점프기능 후가
    * 대쉬키 추가
    * Hurt시 플레이어 넉백 추가
  * 몬스터 추가
    * 개구리 추가
      * 개구리 Idle 애니메이션 추가
      * Dead 애니메이션 추가
    * 독수리추가
      * 독수리 Idle 애니메이션 추가
      * Dead 애니메이션 추가
      * 이동로직 추가
    * Possum 추가
      * Run 애니메이션 추가
      * Possum 이동로직 추가
  * 몬스터를 밟을 시 점프
  * 플레이어 사망 추가
	* 사망 시 애니메이션 추가
  * 점수제 추가
	* coin 애니메이션 추가
	* 캐릭터가 몬스터 kill 혹은 Coin 획득 시 +1
  * UI 추가
	* 점수UI 추가(몬스터 kill 혹은 Coin 획득)
	* 플레이어 LifeUI 추가
	* Retry 버튼(기능) 추가
	* 스테이지의 끝에 도달 시 NextStage 버튼(기능) 추가
	* Exit 버튼(기능) 추가
  * 타이틀 화면 추가
    * 게임시작 버튼 추가
    * 종료버튼 추가
    * 각 버튼 이벤트에 트랜지션 효과 추가
  * BGM 추가
    * Stage1 BGM 추가
    * Stage2 BGM 추가
    * Stage3 BGM 추가
    * Stage4 BGM 추가
    * Stage5 BGM 추가
    * Stage6 BGM 추가
  *SFX 추가
    * playerDeath SFX 추가
    * playerJump  SFX 추가
    * playerDash  SFX 추가
    * playerHurt  SFX 추가
    * playerLanding  SFX 추가
    * playerCoutching  SFX 추가
    * stageClear  SFX 추가
    * enemyDeath  SFX 추가
-----------------


