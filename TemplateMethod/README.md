TemplateMethod Pattern
================================================================

<p align="center"><img src="TemplateMethod.gif" width="80%" height="70%" title="Strategy 클래스 다이어그램" alt="Strategy 클래스 다이어그램"></img></p>

템플릿 메소드 패턴(Template Method Pattern)은 소프트웨어 공학에서 동작 <strong>상의 알고리즘의 프로그램 뼈대를 정의하는 디자인 패턴</strong>이다. 알고리즘의 구조를 변경하지 않고 알고리즘의 특정 단계들을 다시 정의할 수 있게 해준다.

### 의도
- 객체의 연산에는 알고리즘의 뼈대만을 정의하고 각 단계에서 수행할 구체적 처리는 서브클래스 쪽으로 미룹니다. 알고리즘의 구조 자체는 그대로 놔둔 채 알고리즘 각 단게 처리를 서브 클래스에서 재 정의할 수 있게 합니다.

### 활용성
템플릿 메서드 패턴은 다음의 경우에 사용해야 합니다.
- 어떤 한 알고리즘을 이루는 부분 중 변하지 않는 부분을 한번 정의해 놓고 다양해질 수 있는 부분은 서브 클래스에서 정의할 수 있도록 남겨두고자 할때
- 서브클래스 사이의 공통적인 행동을 추출하여 하나의 공통 클래스에 몰아둠으로써 코드 중복을 피하고 싶을 때. 먼저, 기존 코드에서 나타나는 차이점을 뽑아 이를 별도의 새로운 연산들로 구분해 놓습니다. 그런 뒤 달라질 코드 부분을 이 새로운
  연산을 호출하는 템플릿 메서드로 대체하는 것입니다.
- 서브클래스의 확장을 제어할 수 있습니다. 템플릿 메서드가 어떤 특정한 시점에 훅(Hook) 연산을 호출하도록 정의함으로써, 그 특정 시점에서만 확장되도록 합니다.

### 결과
템플릿 메서드는 코드 재사용을 위한 기본 기술입니다. 특히 클래스 라이브러리 구현시 중요시 기술인데, 이는 라이브러리에 정의할 클래스들의 공통 부분을 분리하는 수단이기 때문입니다.

부모 클래스는 서브 클래스에 정의된 연산을 호출 할 수 있찌만 반대 방향으 호출은 안됩니다. <br>
"할리우드 원칙(Hollywood principle)"

템플릿 메서드는 여러 종류의 연산 중 하나를 호출합니다.
- 구구체 연산(Concreate Operation): ConcreateClass나 사용자 클래스에 정의된 연산
- AbstractClass 구체 연산: 서브클래스에서 일반적으로 유용한 연산
- 기본 연산: 추상화된 연산
- 팩토리 메서드
- <strong>훅 연산(Hook Operation)</strong>: 필요하다면 서브클래스에서 확장할 수 있는 기본 행동을 제공하는 연산. 기본적으로는 아무 내용도 정의하지 않습니다.

템플릿 메서드 패턴에서는 어떤 연산이 훅 연산인지(오버라이드가 가능한지) 추상 연산인지(꼭 오버라이드해야 하는지)를 지정해 두는 것이 대단히 중요합니다. 훅은 나중에 재정의할 수도 있고, 재정의하지 않을 수도 있는 메서드이고, 추상 연산은 
반드시 재정의해야 하는 연산입니다. 추상할 클래스를 효과적으로 재사용하기 위해서, 서브클래스 작성자는 어떤 연산들이 오버라이드용으로 설계되었는지를 정확하게 이해하고 있어야 합니다.

서브클래스는 부모 클래스에 정의된 연산을 명시적으로 호출하고 또 재정의함으로써 부모 클래스 연산의 행동을 확장합니다.

<pre><code>
public override void ShowDisplayMessage(string text)
{
    // ========================= 확장할 내용 추가
    base.ShowDisplayMessage("=========================");
    Console.WriteLine("\t[{0}]={1}", GetType().Name, text);
    base.ShowDisplayMessage("=========================");
}
</code></pre>

하지만 간혹 상속받은 연산을 호출하는 일을 잊어버립니다. 그래서 이 같은 서브클래스가 부모 클래스의 행동을 확장하는 연산들을 템플릿 메서드로 옮겨 놓음으로써 부모 클래스에게 서브클래스의 호가장을 제어할 수 있는 권한을 부여할 수 있습니다.
이 아이디어는 부모 클래스의 템플릿 메서드에서 훅 연산을 호출하도록 하는 것입니다. 서브클래스는 이 훅 연산을 재정의할 수 있습니다.

<pre><code>
public void About()
{
    // 부모 클래스가 정의한 행동
    ShowFileVersion();
}
</code></pre>

일반적으로 부모클래스에 정의된 ShowFileVersion은 아무런 행동도 정의하지 않습니다.

<pre><code>
protected virtual void ShowFileVersion() 
{

}
</code></pre>

서브클래스에서는 행동을 확장하려고 ShowFileVersion()을 재정의합니다.
<pre><code>
protected override void ShowFileVersion()
{
    Console.WriteLine("ACropLib.dll Version=1.0.0.0");
}
</pre></code>

### 구현

1. <strong>템플릿 메서드에서 호출하는 기본 연산들을 protected 멤버로 구현합니다.</strong> 이렇게 하면 이 연산들을 템플릿 메서드만 호출할 수 있게 됩니다. 오버라이드해야 하는 기본 연산은
   반드시 순수 가상 함수로 정의합니다. 템플릿 메서드 자체는 재정의되면 안됩니다. 따라서 템플릿 메서드는 비가상 멤버 함수로 만듭니다.

2. <strong>기본 연산의 수를 최소화합니다.</strong> 템플릿 메서드를 구현하는 중요한 목적 중 하나는 알고리즘을 실체화하기 위해 오버라이드해야 하는 기본 연산의 개수를 줄이는 것입니다. 재정의가 필요한
   연산의 수가 많아질수록 사용자에게는 지겨운 일만 늘어납니다.

3. <strong>이름을 짓는 규칙을 만듭니다.</strong> 재정의가 필요한 연산은 식별이 잘 되도록 접두사를 붙이는 것이 좋습니다.

### 시나리오

민수주임이 다니는 회사는 .NET Framework 기반의 솔루션을 개발하고 있습니다. WinForm을 활용하여 개발하고 있는 상황입니다. WinForm 기반의 솔루션에는 A회사, B회사의 장치와 연동되어 개발되고 있는 상황입니다.
민수주임 사수 지훈과장은 민수주임한테 

- A회사 장치 라이브러리는 연결체크 기능을 제공 함
- B회사 장치 라이브러리는 연결체크 기능을 제공 안함

내용을 전달하였습니다. 지훈과장은 A회사 B회사 장치 라이브러리 기능에 대해서는 비슷하여 장치에 연결하는 부분에 대해서만 잘 처리하면 될 거 말합니다.
또 추후에 C회사, D회사 장치 라이브러리 연동이 필요 할수도 있으니 연결체크 기능을 제공하는 장치디바이스 클래스에 대해서는 연결체크기능을 지원한다고 속성을 정의하고 연결체크기능을 제공하는 인터페이스를 구현하라고 말합니다.

여기서 <strong>연결하는 부분과 연결체크 기능을 제공할 떄와 제공을 하지 않을때 에 대한 처리</strong>를 템플릿 메서드로 처리합니다. 연결체크 기능에 대해서는 훅(Hook)연산을 호출하도록 정의합니다.

<strong>AbstractClass=</strong><strong style='color:green'>AbstractDeviceManager</strong></br>
서브 클래스들이 재정의를 통해 구현해야 하는 알고리즘 처리 단계 내의 <strong>기본 연산</strong>을 정의합니다. 그리고 알고리즘의 뼈대를 정의하는 템플릿 메서드를 구현합니다. 템플릿 메서드는 AbstractClass에 정의된 연산 또는 다른
객체 연산뿐만 아니라 기본 연산도 호출합니다.</br>
</br>

A회사, B회사 디바이스 </br>
<strong>ConcreateClass=</strong><strong style='color:green'>ACorpDeviceManager, BCorpDeviceManager</strong></br>
서브클래스마다 달라진 알고리즘 처리 단계를 수행하기 위한 기본 연산을 구현합니다. </br>


### 샘플 출력 결과
<pre><code>
DesignPattern TemplateMethod Pattern
[ACorpDeviceManager]=전원 On
[ACorpDeviceManager]=장치 연결 체크를 지원하는 장치입니다.
[ACorpDeviceManager]=장치에 연결 되어 있습니다.
[ACorpDeviceManager]=연결에 성공하였습니다.Handle=1010
[ACorpDeviceManager]=요청하신 내용을 처리합니다...
ACropLib.dll Version=1.0.0.0
[ACorpDeviceManager]=전원 Off
[BCorpDeviceManager]=전원 On
[BCorpDeviceManager]=연결에 실패하였습니다.Handle=2020
[BCorpDeviceManager]=알수 없는 에러가 발생하였습니다.
[BCorpDeviceManager]=전원 Off
</code></pre>
#### [Wikipedia 링크]
#### https://ko.wikipedia.org/wiki/%ED%85%9C%ED%94%8C%EB%A6%BF_%EB%A9%94%EC%86%8C%EB%93%9C_%ED%8C%A8%ED%84%B4

[ 참고 ] 
- HeadFirst DesignPattern
- GoF의 디자인 패턴
- Java  언어로 배우는 디자인 패턴 입문