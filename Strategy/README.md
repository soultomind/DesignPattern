Strategy Pattern
================================================================

<p align="center"><img src="Strategy.png" width="50%" height="30%" title="Strategy 클래스 다이어그램" alt="Strategy 클래스 다이어그램"></img></p>

전략 패턴(Strategy Pattern)은 실행 중에 알고리즘을 선택할 수 있게 하는 행위 소프트웨어 디자인 패턴 다른 이름으로 정책 패턴(Policy Pattern) 이라고 함
- 특정한 계열의 알고리즘들을 정의
- 각 알고리즘을 캡슐화
- 알고리즘들을 해당 계열 안에서 상호 교체가 가능하게 만듬

활용성
- 하나의 클래스가 많은 행동을 정의하고, 이런 행동들이 그 클래스의 연산안에서 복잡한 다중 조건문의 모습을 취할 때, 많은 조건문보다는 각각을 Strategy 클래스로 옮겨놓는것이 좋다.
- 
#### [Wikipedia 링크]
#### https://ko.wikipedia.org/wiki/%EC%A0%84%EB%9E%B5_%ED%8C%A8%ED%84%B4
================================================================


[ 참고 ] 
- HeadFirst DesignPattern
- GoF의 디자인 패턴
- Java  언어로 배우는 디자인 패턴 입문
