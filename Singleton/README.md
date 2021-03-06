
Singleton Pattern
================================================================

<p align="center"><img src="Singleton.png" width="80%" height="70%" title="Singleton 클래스 다이어그램" alt="Singleton 클래스 다이어그램"></img></p>

소프트웨어 디자인 패턴에서 싱글턴 패턴(Singleton Pattern)을 따르는 클래스는, 생성자가 여러 차례 호출되더라도 실제로 생성되는 객체는 하나이고 최초 생성 이후에 호출 된 생성자는 <strong>최초의 생성자가 생성한 객체를 리턴</strong>한다. 이와 같은 디자인 유형을 싱글턴 패턴이라고 한다.
주로 공통된 객체를 여러개 생성에서 사용하는 DBCP(DataBase Connection Pool)와 같은 상황에서 많이 사용된다.

### 의도
- 오직 한 개의 클래스 인스턴스만을 갖도록 보장하고, 이에 대한 전역적인 접근점을 제공합니다.

### 활용성
단일체 패턴은 다음 상황에서 사용합니다.

- 클래스의 인스턴스가 오직 하나여야 함을 보장하고, 잘 정의된 접근점(Access Point)으로 모든 사용자가 접근할 수 있도록 해야 할 때
- 유일한 인스턴스가 서브클래싱으로 확장되어야 하며, 사용자는 코드의 수정없이 확장된 서브클래스의 인스턴스를 사용할 수 있어야 할 때

### 결과
단일체 패턴이 갖는 장점들을 보면 다음과 같습니다.

1. <strong>유일하게 존재하는 인스턴스로의 접근을 통제합니다.</strong> Singleton 클래스 자체가 인스턴스를 캡슐화하기 때문에, 이 클래스에서 사용자가 언제, 이 인스턴스에 접근할 수 있는지 제어할 수 있습니다.
2. <strong>이름 공간(Name Space)을 좁힙니다.</strong> 단일체 패턴은 전역 변수보다 더 좋습니다. 전역 변수를 사용해서 이름 공간을 망치는 일을 없애주기 때문입니다. 즉 전역 변수를 정의하여 발생하는 디버깅의 어려움
   등 문제를 없앱니다. <strong>(C++ 같은 언어에서만 해당되는듯)</strong>
3. <strong>연산 및 표현의 정제를 허용합니다.</strong> Singleton 클래스는 상속될 수 있기 때문에, 이 상속된 서브클래스를 통해서 새로운 인스턴스를 만들 수 있습니다. 또한 이 패턴을 사용하면, 런타임에 필요한 클래스의
   인스턴스를 써서 응용프로그램을 구성할 수도 있습니다. 
4. <strong>인스턴스의 개수를 변경하기가 자유롭습니다.</strong> 마음이 바뀌어서 Singleton 클래스의 인스턴스가 하나 이상 존재할 수 있또록 변경해야 할 때도 있는데, 이 작업도 어렵지 않습니다. 게다가, 응용프로그램이 사용하는
   인스턴스가 다수여야 할 때도 똑같은 방법을 쓸 수 있습니다. 즉, Singleton 클래스의 인스턴스에 접근할 수 있는 허용 범위를 결정하는 연산만 변경하면 됩니다. 왜냐하면 기존에는 하나의 인스턴스로만 접근을 허용했다면, 이제는 여러 
   개의 인스턴스를 생성해서 그 각각의 인스턴스로 접근할 수 있도록 연산의 구현을 바꾸면 되기 때문입니다.
5. <strong>클래스 연산을 사용하는 것보다 훨씬 유연한 방법입니다.</strong> 단일체 패턴과 동일한 기능을 발휘하는 방법이 클래스 연산을 사용하는 것입니다. 그러나 클래스의 인스턴스가 하나 이상 존재할 수 있도록 설계를 변경하는 
   것은 어렵습니다. 정적 멤버 함수는 가상 함수가 아니므로, 서브클래스들이 이 연산을 오버라이드 할 수 없습니다.


#### [Wikipedia 링크]
#### https://ko.wikipedia.org/wiki/%EC%8B%B1%EA%B8%80%ED%84%B4_%ED%8C%A8%ED%84%B4

[ 참고 ] 
- HeadFirst DesignPattern
- GoF의 디자인 패턴
- Java  언어로 배우는 디자인 패턴 입문